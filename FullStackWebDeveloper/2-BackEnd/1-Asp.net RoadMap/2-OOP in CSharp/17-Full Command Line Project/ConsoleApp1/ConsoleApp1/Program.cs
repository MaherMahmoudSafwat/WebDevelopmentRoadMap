namespace ConsoleApp1
{
    internal class Program
    {
        public static int [] Tickets(int[] tickets)
        {
            int[] tickets2 = new int[tickets.Length];
            tickets2[tickets.Length - 1] = tickets[0];
            for(int i = 1;i<tickets.Length;i++)
            {
                tickets2[i - 1] = tickets[i];
            }
            tickets = tickets2;
            return tickets;
        }
        public static int TimeRequiredToBuy(int[] tickets, int k)
        {
            int Counter = 0;
            int IndexQueueArray = tickets[k];//1 3 2 //3 2 1
            int i = 0;
            int[] tickets2 = new int[tickets.Length]; 
            while(IndexQueueArray>0)
            {
                if (tickets[0]==0)
                {
                    tickets = Tickets(tickets);
                    k--;
                    if (k < 0)
                        k = tickets.Length - 1;
                    IndexQueueArray = tickets[k]; 
                }
                else
                {
                    tickets[0]--;
                    tickets = Tickets(tickets);
                    k--;
                    if (k < 0)
                        k = tickets.Length - 1;
                    IndexQueueArray = tickets[k];
                    Counter++;
                }
            }
            return Counter;
        }
        static void Main(string[] args)
        {
            int[] Arr1Tickets = { 5,1,1,1};
            Console.WriteLine(TimeRequiredToBuy(Arr1Tickets, 0));
        }
    }
}
