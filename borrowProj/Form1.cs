using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace borrowProj
{
    public partial class Form1 : Form
    { 
        Person PersonList = new Person("", 0);
        Person i, currFriend;
        int initCapital = 2000;
        int tradeAmount = 1000;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inputFriendNameLebel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(i != null)i.payback(currFriend, tradeAmount);
            updateMoney();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void borrowButton_Click(object sender, EventArgs e)
        {
            if (i != null) i.borrow(currFriend, tradeAmount);
            updateMoney();
        }

        private void nameSubmitButton_Click(object sender, EventArgs e)
        {
            String my_name = inputMyNameTextbox.Text;
            String friend_name = inputFriendNameTextbox.Text;

            if (my_name == friend_name) return;
            if (my_name == "") return;
            if (friend_name == "") return;

            i = Person.find(my_name, PersonList);
            if (i == null) {
                i = new Person(my_name, 0);
                PersonList.add(i);
            }

            currFriend = Person.find(friend_name, PersonList);
            if (currFriend == null)
            {
                currFriend = new Person(friend_name, initCapital);
                PersonList.add(currFriend);
            }

            myName.Text = i.getName();
            myCapital.Text = " " + i.getCapital() + " 元";
            friendName.Text = friend_name;
            friendCapital.Text = " " + currFriend.getCapital() + " 元";

            borrowButton.Enabled = true;
            borrowButton.Text = "向 " + friend_name + " 借 " + tradeAmount + " 元 ";
            paybackButton.Enabled = true;
            paybackButton.Text = "還 " + friend_name + " " + tradeAmount + " 元 ";

            //PersonList.traversal();
        }

        private void updateMoney() {
            if (i != null) myCapital.Text = " " + i.getCapital() + " 元";
            if (currFriend != null) friendCapital.Text = " " + currFriend.getCapital() + " 元";

        }
    }
}
