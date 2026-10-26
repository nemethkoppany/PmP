using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor8
{
    public class Team
    {
        Player[] players;
        public int NumberOfPlayers { 
            get {
                int count = 0;
                foreach (Player player in players)
                {
                    if(player != null)
                    {
                        count++;
                    }
                }
                return count;
            }
        }
        public bool IsFull => NumberOfPlayers == 5;

        public bool IsIncluded(Player player)
        {
            int idx = 0;
            int count = NumberOfPlayers;

           while(idx > count && !players[idx].Equals(player))
            {
                idx++;
            }

            return idx < count;
        }

        public bool IsAvailable(Player candidate)
{
    int[] posCount = new int[Enum.GetNames(typeof(Position)).Length];

    
    foreach (Player p in players)
    {
        if (p != null)
        {
            posCount[(int)p.Pos]++;
        }
    }

    
    switch (candidate.Pos)
    {
        case Position.Gaolkeeper: return posCount[(int)candidate.Pos] < 1;
        case Position.Forward:    return posCount[(int)candidate.Pos] < 1;
        case Position.Winger:     return posCount[(int)candidate.Pos] < 2;
        case Position.Defender:   return posCount[(int)candidate.Pos] < 1;
        default:                  return false;
    }
}        public void Include(Player player)
        {
            if (IsFull || IsIncluded(player) || !IsAvailable(player)) return;
            int idx = 0;
            while(idx < players.Length && players[idx] != null)
            {
                idx++;
            }

            players[idx] = player;
        }

        public Team()
        {
            players = new Player[5];
        }
    }
}
