using Abstractions;
using Abstractions.Commands;
using System;
using UniRx;
using UnityEngine;
using UserControlSystem.CommandsRealization;
using Utils;
using Zenject;

namespace UserControlSystem
{
    public class RightClickManager : IInitializable, IDisposable
    {
        private readonly IObservable<ISelectable> _selectable;
        private readonly IObservable<Vector3> _vector3Value;
        private IDisposable _disposableSelectable;
        private IDisposable _disposableVector3;
        private ICommandsQueue _queue;

        [Inject]
        private RightClickManager(IObservable<ISelectable> selectable, IAwaitable<Vector3> vector3Value)
        {
            _selectable = selectable;
            _vector3Value = (IObservable<Vector3>)vector3Value;
        }

        public void Initialize()
        {
            _disposableSelectable = _selectable.Subscribe(OnSelected);
            _disposableVector3 = _vector3Value.Subscribe(OnVector3);
        }

        public void Dispose()
        {
            _disposableSelectable.Dispose();
            _disposableVector3.Dispose();
        }

        private void OnSelected(ISelectable selectable)
        {
            if (selectable == null)
            {
                _queue = null;
            }
            else
            {
                _queue = (selectable as Component).GetComponent<ICommandsQueue>();
            }
        }

        private void OnVector3(Vector3 value)
        {
            if (_queue != null)
            {
                _queue.EnqueueCommand(new MoveCommand(value));
            }
        }

       
    }
}
