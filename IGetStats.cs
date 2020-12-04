using System.Collections.Generic;

namespace Exam2part3
{
    public interface IGetStats
    {
        List<QBStats> GetQBStats();
        List<RBStats> GetRBStats();
        List<WRStats> GetWRStats();
    }
}