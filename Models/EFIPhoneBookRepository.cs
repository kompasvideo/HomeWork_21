using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork_21.Models
{
    public class EFPhoneBookRepository : IPhoneBookRepository
    {
        private ApplicationDBContext context;

        public EFPhoneBookRepository(ApplicationDBContext ctx)
        {
            context = ctx;
        }

        public IQueryable<PhoneBook> PhoneBooks => context.PhoneBooks;

        public PhoneBook DeleteRecord(int phoneBookID)
        {
            PhoneBook dbEntry = context.PhoneBooks.FirstOrDefault(p => p.PhoneBookID == phoneBookID);
            if (dbEntry != null)
            {
                context.PhoneBooks.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

        public void SaveRecord(PhoneBook phoneBook)
        {
            if (phoneBook.PhoneBookID == 0)
            {
                context.PhoneBooks.Add(phoneBook);
            }
            else
            {
                a
            }
            context.SaveChanges();
        }
    }
}
