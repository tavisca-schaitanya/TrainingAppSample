using System;
using System.Collections.Generic;
using System.Text;
using TrainingApp.Common.Models;

namespace TrainingAppDAL
{
    public class InMemoryStorage
    {
        public List<Trainer> TrainersList;
        public List<Trainee> TraineesList;
        public List<LoginDetails> LoginDetailsList;

        public InMemoryStorage()
        {
            LoginDetailsList = new List<LoginDetails>()
            {
                new LoginDetails()
                {
                    Role = Roles.TRAINEE,
                    Email = "xyz@gmail.com",
                    Password = "12345"
                },
                new LoginDetails()
                {
                    Role = Roles.TRAINER,
                    Email = "abc@gmail.com",
                    Password = "Tavisca123"
                }
            };

            TraineesList = new List<Trainee>()
            {
                new Trainee()
                {
                    Id = "1",
                    Name = "Chaitanya",
                    Email = "xyz@gmail.com",
                    PhoneNumber = "8889997700",
                    Designation = "Training",
                    BatchId = 1
                }
            };

            TrainersList = new List<Trainer>()
            {
                new Trainer()
                {
                    Id = "2",
                    Name = "Pankaj",
                    Email = "abc@gmail.com",
                    PhoneNumber = "9998887700",
                    Designation = "Technical Architect",
                    Technology = ".NET",
                    Tribe = "Flights"
                }
            };
        }
    }
}
