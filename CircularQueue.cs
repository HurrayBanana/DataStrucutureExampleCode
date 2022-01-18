    /// <summary>
    /// implements a Circular queue
    /// </summary>
    class QueueC
    {
        private string[] q;
        
        /// <summary>
        /// front pointer
        /// </summary>
        private int f;
        
        /// <summary>
        /// rear pointer
        /// always points to free space
        /// </summary>
        private int r;

        /// <summary>
        /// holds number of items in queue
        /// </summary>
        private int count;
        
        public QueueC(int maxsize)
        {
            q = new string[maxsize];
            Reset();
        }
        private void Reset()
        {
            f = 0;
            r = 0;
            count = 0;
        }
        public void EnQueue(string item)
        {
            if (count == q.Length)
            {
                Console.WriteLine("Queue full - wahhhhhahhh");
            }
            else
            {
                count++;
                q[r] = item;

                //increment and wrap rear pointer using logic
                r = r + 1;
                if (r > q.Length) 
                {
                    r = 0;
                }
            }
        }

        /// <summary>
        /// attempts to return front of queue
        /// </summary>
        /// <returns>the date item or null if empty</returns>
        public string DeQueue()
        {
            if (count == 0)
            {
                Console.WriteLine("Q Empty ':->");
            }
            else 
            {
                count--;
                string item = q[f];
                
                //increment and wrap front pointer using mod operator (%) this time
                //(same process as we did for rear pointer in EnQueue)
                f = (f + 1) % q.Length;

                return item;
            }
            return null;
        }
    }
