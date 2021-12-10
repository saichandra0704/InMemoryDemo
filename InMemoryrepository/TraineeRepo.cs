using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InMemoryRepository
{
    public class TraineeRepo : ITrainee
    {
        static List<Trainee> TraineeList { get; }

        static TraineeRepo()
        {
            TraineeList = new List<Trainee>()
            {
                new Trainee()
                {
                    TraineeID = 1001,
                    TraineeName = "Aiswarya",
                    TrainingTrack = ".NET fse"
                },
                new Trainee()
                {
                    TraineeID = 1002,
                    TraineeName = "Rakesh",
                    TrainingTrack = ".NET fse"
                },
                new Trainee()
                {
                    TraineeID = 1003,
                    TraineeName = "Shivanand",
                    TrainingTrack = ".NET fse"
                },
                new Trainee()
                {
                    TraineeID = 1004,
                    TraineeName = "Katyayini",
                    TrainingTrack = ".NET fse"
                },
            };
        }

        public void SaveTrainee(Trainee NewTrainee)
        {
            TraineeList.Add(NewTrainee);
        }

        public List<Trainee> GetAllTrainees()
        {
            return TraineeList;
        }

        public Trainee GetTrainee(int TraineeID)
        {
            return TraineeList.FirstOrDefault(t => t.TraineeID == TraineeID);
        }

        public int UpdateTrainee(Trainee TraineeModified)
        {
            int LocationOfRecord = TraineeList.FindIndex(tr => tr.TraineeID == TraineeModified.TraineeID);

            if (LocationOfRecord == -1)
                return -1;
            else
            {
                TraineeList[LocationOfRecord] = TraineeModified;
                return 1;
            }
        }

        public int DeleteTrainee(int TraineeID)
        {
            Trainee TraineeNeededtobeDeleted = GetTrainee(TraineeID);
            if (TraineeNeededtobeDeleted != null)
            {
                TraineeList.Remove(TraineeNeededtobeDeleted);
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
