using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302223007
{
    public enum KarakterState
    {
        Berdiri, Jongkok, Tengkurap, Terbang
    }

    public enum Trigger
    {
        TombolS, TombolW, TombolX
    }

    internal class PosisiKarakterGame
    {
        public class Transition
        {
            public KarakterState stateAwal;
            public KarakterState stateAkhir;
            public Trigger trigger;

            public Transition(KarakterState stateAwal, KarakterState stateAkhir, Trigger trigger)
            {
                this.stateAwal = stateAwal;
                this.stateAkhir = stateAkhir;
                this.trigger = trigger;
            }
        }

        Transition[] transisi =
        {
            new Transition(KarakterState.Berdiri, KarakterState.Terbang, Trigger.TombolW),
            new Transition(KarakterState.Terbang, KarakterState.Berdiri, Trigger.TombolS),
            new Transition(KarakterState.Terbang, KarakterState.Jongkok, Trigger.TombolX),
            new Transition(KarakterState.Berdiri, KarakterState.Jongkok, Trigger.TombolS),
            new Transition(KarakterState.Jongkok, KarakterState.Berdiri, Trigger.TombolW),
            new Transition(KarakterState.Jongkok, KarakterState.Tengkurap, Trigger.TombolS),
            new Transition(KarakterState.Tengkurap, KarakterState.Jongkok, Trigger.TombolW)
        };

        public KarakterState currState = KarakterState.Berdiri;

        public KarakterState GetNextState(KarakterState stateAwal, Trigger trigger)
        {
            KarakterState stateAkhir = stateAwal;

            for (int i = 0; i < transisi.Length; i++)
            {
                Transition perubahan = transisi[i];

                if (stateAwal == perubahan.stateAwal && trigger == perubahan.trigger)
                {
                    stateAkhir = perubahan.stateAkhir;
                }
            }

            return stateAkhir;
        }

        public void ActivateTrigger(Trigger trigger)
        {
            currState = GetNextState(currState, trigger);
            
            if (trigger == Trigger.TombolW && currState == KarakterState.Terbang)
            {
                Console.WriteLine("posisi take off");
            }

            if (trigger == Trigger.TombolX && currState == KarakterState.Jongkok)
            {
                Console.WriteLine("posisi landing");
            }
        }


        public void SimulasiTrigger(Trigger trigger)
        {
            currState = GetNextState(currState, trigger);
            Console.WriteLine(trigger);
            Console.WriteLine("->" + currState);
        }
    }
}
