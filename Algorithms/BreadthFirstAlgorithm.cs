using System;
using System.Collections.Generic;

namespace Algorithms
{
	public class Employee
	{
		public Employee(string name)
		{
			this.name = name;
		}

		public string name { get; set; }
		public List<Employee> Employees
		{
			get
			{
				return EmployeesList;
			}
		}

		public void isEmployeeOf(Employee p)
		{
			EmployeesList.Add(p);
		}

		List<Employee> EmployeesList = new List<Employee>();

		public override string ToString()
		{
			return name;
		}
	}

	public class BreadthFirstAlgorithm
	{
		public Employee BuildEmployeeGraph()
		{
			Employee Eva = new Employee("Eva");
			Employee Sofia = new Employee("Sofia");
			Employee Rahul = new Employee("Rahul");
			Eva.isEmployeeOf(Sofia);
			Eva.isEmployeeOf(Rahul);

			Employee Lisa = new Employee("Lisa");
			Employee Tina = new Employee("Tina");
			Employee John = new Employee("John");
			Employee Mike = new Employee("Mike");
			Sofia.isEmployeeOf(Lisa);
			Sofia.isEmployeeOf(John);
			Rahul.isEmployeeOf(Tina);
			Rahul.isEmployeeOf(Mike);

			return Eva;
		}

		public Employee Search(Employee root, string nameToSearchFor)
		{
			Queue<Employee> Q = new Queue<Employee>();
			HashSet<Employee> S = new HashSet<Employee>();
			Q.Enqueue(root);
			S.Add(root);

			while (Q.Count > 0)
			{
				Employee e = Q.Dequeue();
				if (e.name == nameToSearchFor)
					return e;
				foreach (Employee friend in e.Employees)
				{
					if (!S.Contains(friend))
					{
						Q.Enqueue(friend);
						S.Add(friend);
					}
				}
			}
			return null;
		}

        public bool PathExists(Employee root, string fromName, string toName) 
        {
            if (fromName == toName) {
                return true;
            }

			Queue<Employee> Q = new Queue<Employee>();
			HashSet<Employee> S = new HashSet<Employee>();
            Employee fromN = Search(root, fromName);

			Q.Enqueue(fromN);
			S.Add(fromN);

			while (Q.Count > 0)
			{
				Employee e = Q.Dequeue();
                if (e.name == toName)
                {
                    return true;
                }
                foreach (Employee colleague in e.Employees)
				{
					if (!S.Contains(colleague))
					{
						Q.Enqueue(colleague);
						S.Add(colleague);
					}
				}
			}

            return false;
        }

		public void Traverse(Employee root)
		{
			Queue<Employee> traverseOrder = new Queue<Employee>();

			Queue<Employee> Q = new Queue<Employee>();
			HashSet<Employee> S = new HashSet<Employee>();
			Q.Enqueue(root);
			S.Add(root);

			while (Q.Count > 0)
			{
				Employee e = Q.Dequeue();
				traverseOrder.Enqueue(e);

				foreach (Employee emp in e.Employees)
				{
					if (!S.Contains(emp))
					{
						Q.Enqueue(emp);
						S.Add(emp);
					}
				}
			}

			while (traverseOrder.Count > 0)
			{
				Employee e = traverseOrder.Dequeue();
				Console.WriteLine(e);
			}
		}
	}
}
