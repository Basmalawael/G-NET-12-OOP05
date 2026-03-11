using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_12_OOP05.NewFolder
{
    #region Ticket
    /*
     internal class Ticket : IPrintable, IBookable, ICloneable

     {

         public int TicketId { get; set; }
         public string MovieName { get; set; }
         public decimal Price { get; set; }
         public decimal PriceAfterTax { get; set; }
         public bool IsBooked { get; set; } 

         //Ctor
         public Ticket(int ticketId , string movieName , decimal price)
         {
             TicketId = ticketId;
             MovieName = movieName;
             Price = price;
             PriceAfterTax = Price * 1.14m;  
         }

         //Method 
         public void SetPrice(decimal price)
         {
             Price = price;
         }

         public void SetPrice(decimal baseprice, decimal multiplier)
         {
             Price = baseprice * multiplier;
         }

         public virtual void PrintTicket()
         {
             PriceAfterTax = Price * 1.14m;

       Console.WriteLine($" Ticket : {TicketId} | {MovieName} | Price: {Price} EGP" +
        $" | After Tax:{PriceAfterTax: F2} EGP ");
         }
         //----------------------------------------
         public virtual void PrintInfo()
         {
             string status = IsBooked ? "Yes" : "No";
             Console.Write($"[Ticket #{TicketId}] {MovieName} ");
         }

         public void Book()
         {
             if (IsBooked) throw new Exception("Already booked..!");
             IsBooked = true;
         }

         public void Cancel()
         {
             if (!IsBooked) throw new Exception("Not booked..!");
             IsBooked = false;
         }

         public object Clone()
         {
             return this.MemberwiseClone();
         }
     }
     */
    #endregion
}