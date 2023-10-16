using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class TripScheduler
    {
        private List<IVisitTouristAttraction> commands = new List<IVisitTouristAttraction>();

        public void AddCommand(IVisitTouristAttraction command)
        {
            commands.Add(command);
        }
        public void removeCommands()
        {
            commands.Clear();
        }
        public void Trip()   
            {
                foreach (var command in commands)
                {
                    command.Visit();
                }
            }
    }

