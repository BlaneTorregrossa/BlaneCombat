using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlaneCombat
{
    public interface iDamageable
    {
        void TakeDamage(int amount);
    }

    public interface iDamager
    {
        void DoDamage();
    }
}
