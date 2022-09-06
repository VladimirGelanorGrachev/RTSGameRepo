using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;

namespace UserControlSystem.CommandsRealization
{
    public sealed class PatrolCommand : IPatrolCommand
    {
        private Vector3 _position;
        private Vector3 _groundClick;

        public Vector3 From { get;}

        public Vector3 To { get;}

       

        public PatrolCommand(Vector3 From, Vector3 To)
        {
            From = _position;
            To = _groundClick;
        }
    }
}