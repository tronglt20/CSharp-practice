using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.IO;

namespace Dependencies
{
    interface IClassB
    {
        public void ActionB();
    }

    interface IClassC
    {
        public void ActionC();
    }

    class ClassA
    {
        IClassB b_dependency;

        public void ActionA()
        {
            Console.WriteLine("Action class A");
            b_dependency.ActionB();
        }
        public ClassA(IClassB classB)
        {
            this.b_dependency = classB;
        }
    }

    class ClassB : IClassB
    {
        IClassC c_dependency;
        public void ActionB()
        {
            Console.WriteLine("Action class B");
            c_dependency.ActionC();
        }

        public ClassB(IClassC classC)
        {
            c_dependency = classC;
        }

    }

    class ClassC : IClassC
    {
        public void ActionC()
        {
            Console.WriteLine("Action class C");
        }
    }

    class ClassC1 : IClassC
    {
        public ClassC1()
        {
            Console.WriteLine("Class C1 is created");
        }
        
        public void ActionC()
        {
            Console.WriteLine("Action class C1");
        }
    }


    class ClassB1 : IClassB
    {

        IClassC c_dependency;
        public void ActionB()
        {
            Console.WriteLine("Action class B1");
            c_dependency.ActionC();
        }

        public ClassB1(IClassC classC)
        {
            c_dependency = classC;
        }
    }

    class ClassB2 : IClassB
    {

        IClassC c_dependency;
        string message;
        public void ActionB()
        {
            Console.WriteLine("Action class B2");
            Console.WriteLine($"- Message: {message}");
            c_dependency.ActionC();
        }

        public ClassB2(IClassC classC, IOptions<B2ServiceOption> option)
        {
            c_dependency = classC;
            B2ServiceOption opts = option.Value ;
            message = opts.message;
        }
    }   

    class B2ServiceOption
    {
        public string message { get; set; }
    }

   

    class Program
    {
       /* public static ClassB2 CreateB2Factory(IServiceProvider serviceprovider) {
                var service_c = serviceprovider.GetService<IClassC>();
                var sv = new ClassB2(service_c, "Class B2 action x2");
                return sv;
         }*/

        static void Main(string[] args)
        {
            var services = new ServiceCollection();

            services.AddSingleton<ClassA, ClassA > ();
           /* services.AddSingleton<IClassB, ClassB>();*/
            services.AddSingleton<ClassB2>();
            services.AddSingleton<IClassC, ClassC1>();

            // Đăng ký cấu hình 
            services.Configure<MyServiceOptions>(opts => {
                opts.data1 = "This is data 1";
                opts.data2 = "This is data 2";
            });

            services.Configure<B2ServiceOption>(opt =>
            {
                opt.message = "This is B2 option xxxx";
            });

            services.AddSingleton<MyService>();

            // Inject options from file
            IConfigurationRoot configurationRoot;

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json");
            
            configurationRoot = builder.Build();

            var key1 = configurationRoot
                            .GetSection("Option2")
                            .GetSection("key1").Value;

            Console.WriteLine(key1);


            var provider = services.BuildServiceProvider();

           /* for (int i = 0; i < 5; i++)
            {
                var service1 = provider.GetService<IClassB>();
                Console.WriteLine(service1.GetHashCode());
            }

            var service = provider.GetService<ClassA>();
            service.ActionA();*/

            /*var myService = provider.GetService<MyService>();
            myService.PrintData();

            var classB = provider.GetService<ClassB2>();
            classB.ActionB();*/
            /*  IClassC classC = new ClassC1();
              IClassB classB = new ClassB1(classC);
              ClassA classA = new ClassA(classB);

              classA.ActionA();*/
        }
    }
}
