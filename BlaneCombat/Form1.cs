using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlaneCombat
{
    public partial class Form1 : Form
    {
        enum States
        {
            init, idle, dead, exit
        }

        public Form1()
        {
            InitializeComponent();

            Party pOne = new Party(2);
            Party pTwo = new Party(2);

            pOne.AddPartyMember(new Character("Blane", 100, 10, 1));
            pOne.AddPartyMember(new Character("Walle", 100, 10, 3));

            pTwo.AddPartyMember(new Character("Dylan", 100, 10, 2));
            pTwo.AddPartyMember(new Character("Matthew", 100, 10, 4));

            Combat CombatInstance = new Combat();
            CombatInstance.SetEnemyParty(pTwo);
            CombatInstance.SetPlayerParty(pOne);

            CombatInstance.SetActiveCharacter();
            CombatInstance.SetActiveCharacter();
            CombatInstance.SetActiveCharacter();
            CombatInstance.SetActiveCharacter();
            CombatInstance.SetActiveCharacter();

            pOne.PartyMembers[0].SetTarget(pTwo.PartyMembers[0]);
            pOne.PartyMembers[0].DoDamage();

            FiniteStateMachine<States> FSM = new FiniteStateMachine<States>();

            FSM.AddTransiton(States.init, States.idle);
            FSM.AddTransiton(States.idle, States.dead);
            FSM.AddTransiton(States.dead, States.exit);

            FSM.TryTransition(States.init);
            FSM.TryTransition(States.exit);
            FSM.TryTransition(States.idle);
            FSM.TryTransition(States.init);
            FSM.TryTransition(States.idle);
            FSM.TryTransition(States.dead);
            FSM.TryTransition(States.exit);
        }
    }
}
