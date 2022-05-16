using System;
using Reflection;
class Program
{
    public static void Main(String[] args)
    {
        Customer customer = new Customer(105,"vinay");
        customer.PrintName();
        customer.PrintId();
        Customer.Test();
    }
}
