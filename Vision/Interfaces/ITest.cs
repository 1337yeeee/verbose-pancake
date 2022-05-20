using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vision.Models;

namespace Vision.Interfaces {
	public interface ITest {
		Task<IList<Test>> allTests();

		Task createTest(string name, double price);

		Task delete(Guid id);
	}
}
