using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumsSystem.Model
{
    class Managment:Policy
    {

        double seniority;
        double timeBan;
        int numOfComplaint;
        public int getNumOfBaning(int sforum) {
            return 1;
        }
        public void adminAdapter(Member m) { }
        public Managment getMP() {
            return new Managment();
        }

    }
}
