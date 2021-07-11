using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace borrowProj
{
    class Person
    {
        private String name;
        private int captial;
        private Person next;

        public Person(String name, int money = 0)
        {
            this.name = name;
            this.captial = money;
            this.next = null;
        }
        private bool decuction(int money)
        {
            if (this.captial >= money)
            {
                this.captial = this.captial - money;
                return true;
            }
            else
            {
                return false;
            }
        }
        private void deposit(int money)
        {
            this.captial = this.captial + money;
        }

        public String getName()
        {
            return this.name;
        }

        public int getCapital()
        {
            return this.captial;
        }

        public void borrow(Person lender, int money)
        {
            if (lender.decuction(money))
            {
                this.deposit(money);
            }
            else
            {
                MessageBox.Show(lender.name + " has no enough money. ");
            }
        }

        public void payback(Person lender, int money)
        {
            if (this.decuction(money))
            {
                lender.deposit(money);
            }
            else
            {
                MessageBox.Show("You have no enough money. ");
            }
        }

        public void add(Person nextPerson)
        {
            Person temp = this;
            while (temp.next != null) {
                temp = temp.next;
            }
            temp.next = nextPerson;
        }

        public static Person find(String name, Person p) {
            if (p == null || name == "") return null;

            while (p != null)
            {
                if (p.name == name) {
                    return p;
                }
                else
                {
                    p = p.next;
                }      
            }
            return null;
        }
  

        public void traversal() {
            if (this == null) return;

            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Capital: " + this.captial);
            MessageBox.Show("traversal->Name: " + this.name);
            if(this.next != null)this.next.traversal();
        }

    }
}