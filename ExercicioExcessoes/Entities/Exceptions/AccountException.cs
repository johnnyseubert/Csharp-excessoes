using System;

namespace ExercicioExcessoes.Entities.Exceptions
{
    public class AccountException : Exception
    {
        public AccountException(string message) : base(message)
        {
            //mensagem recebita pelo parametro é repassado para a 
            //base ApplicationException
        }
    }
}