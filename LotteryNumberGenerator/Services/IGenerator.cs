using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryNumberGenerator.Services
{
    public interface IGenerator
    {
        IList<int> GenerateNumbers();
    }
}
