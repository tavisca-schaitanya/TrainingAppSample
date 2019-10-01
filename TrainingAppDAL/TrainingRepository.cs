using System;
using System.Collections.Generic;
using System.Text;
using TrainingApp.Common.Models;

namespace TrainingAppDAL
{
    public class TrainingRepository
    {
        private InMemoryStorage _storage;

        public TrainingRepository()
        {
            _storage = new InMemoryStorage();
        }

        public Employee Authenticate(User user)
        {
            var userObj = _storage.LoginDetailsList.Find(
                loginUser => loginUser.Email == user.EmailId && 
                loginUser.Password == user.Password && 
                loginUser.Role == user.Role
                );

            if (userObj == null)
                return null;

            if (user.Role == Roles.TRAINEE)
                return _storage.TraineesList.Find(trainee => trainee.Email == user.EmailId);

            else if (user.Role == Roles.TRAINER)
                return _storage.TrainersList.Find(trainer => trainer.Email == user.EmailId);

            return null;
        }

        public bool VerifyEmail(User user)
        {
            var loginUserObj = _storage.LoginDetailsList.Find(
                loginUser => loginUser.Email == user.EmailId && 
                loginUser.Role == user.Role
                );

            return loginUserObj != null;
        }
    }
}
