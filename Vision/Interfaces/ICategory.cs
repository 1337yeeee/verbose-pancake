using System;
using System.Collections.Generic;
using Vision.Storage;

namespace Vision.Interfaces {
	public interface ICategory {
		IEnumerable<Category> AllCategories { get; }
	}
}
