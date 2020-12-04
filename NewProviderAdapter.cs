using System.Collections.Generic;

namespace Exam2part3
{
    public class NewProviderAdapter : IGetStats
    {
        private NewProvider stats;

        public NewProviderAdapter(NewProvider stats)
        {
            this.stats = stats;
        }

        public List<QBStats> GetQBStats()
        {
            List<OffensiveStats> oStats = stats.GetOffensiveStats();
            List<QBStats> qbStats = new List<QBStats>();
            foreach(OffensiveStats player in oStats){
                if(player.Position == "QB"){
                    QBStats tempPlayer = new QBStats(){ID=player.ID, PassingYards=player.PassingYards, RushingYards=player.RushingYards, PassingTDs=player.PassingTDs, RushingTDs=player.RushingTDs};
                    qbStats.Add(tempPlayer);

                }
            }
            return  qbStats;
        }


        public List<RBStats> GetRBStats()
        {
            List<OffensiveStats> oStats = stats.GetOffensiveStats();
            List<RBStats> RBStats = new List<RBStats>();
            foreach(OffensiveStats player in oStats){
                if(player.Position == "RB"){
                    RBStats tempPlayer = new RBStats(){ID=player.ID, ReceivingYards=player.ReceivingYards, RushingYards=player.RushingYards, ReceivingTDs=player.ReceivingTDs, RushingTDs=player.RushingTDs};
                    RBStats.Add(tempPlayer);

                }
            }
            return RBStats;
        }

        public List<WRStats> GetWRStats()
        {
              List<OffensiveStats> oStats = stats.GetOffensiveStats();
            List<WRStats> WRStats = new List<WRStats>();
            foreach(OffensiveStats player in oStats){
                if(player.Position == "WR"){
                    WRStats tempPlayer = new WRStats(){ID=player.ID, ReceivingYards=player.ReceivingYards, RushingYards=player.RushingYards, ReceivingTDs=player.ReceivingTDs, RushingTDs=player.RushingTDs};
                    WRStats.Add(tempPlayer);

                }
            }
            return WRStats;
        }
    }
}