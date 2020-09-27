using KeyBOard.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeyBOard.Models
{
    public class SellContext : DbContext
    {
        public DbSet<KeyBoardDTO> KeyBoards { get; set; }

        public SellContext()
        {
            Database.EnsureCreated();
        }
    }
}
