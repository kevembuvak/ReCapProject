using Business.Concrete;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Program
    {
        CarManager carManager = new CarManager(new InMemoryCarDal());
    }
}
