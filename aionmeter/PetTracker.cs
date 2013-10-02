/* 
AIONMeter is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

AIONMeter is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with AIONMeter.  If not, see <http://www.gnu.org/licenses/>.

Hüseyin Uslu, <shalafiraistlin nospam gmail dot com> 
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace AIONMeter
{
    public class PetTracker : IDisposable
    {
        public List<Pet> active_pets;
        private bool disposed = false;

        public PetTracker()
        {
            if (active_pets == null) // init the structure
                active_pets = new List<Pet>();
            else
                active_pets.Clear(); // reset if already inited
        }

        public void track(Pet p)
        {
            active_pets.Add(p);
        }

        public void remove(Pet p) // Players may summon new pets, so they should be removed from Pet Tracker
        {
            active_pets.Remove(p);
        }

        public void commit_pet_action(string time, string who, Int32 amount, string target, string skill)
        {
            if (active_pets != null && active_pets.Count > 0)
            {
                foreach (Pet pet in active_pets)
                {
                    if (pet.name == who)
                    {
                        pet.commit_action(time, who, amount, target, skill);
                        break;
                    }
                }
            }
        }

        ~PetTracker()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); // the GC shouldn't try to finalize the object as disposed it
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if (active_pets != null)
                    {
                        foreach (Pet p in active_pets)
                        {
                            p.Dispose();
                        }
                        active_pets.Clear();
                        active_pets = null;
                    }
                }
            }
            disposed = true;
        }
    }
}
