using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace InMemoryRepository
{
    public interface ITrainee
    {
        public void SaveTrainee(Trainee NewTrainee);
        public List<Trainee> GetAllTrainees();
        public Trainee GetTrainee(int TraineeID);
        public int UpdateTrainee(Trainee TraineeModified);
        public int DeleteTrainee(int TraineeID);
    }
}
