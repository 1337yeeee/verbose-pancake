using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vision.Storage
{
	public class Article
	{
		[Key]
		Guid id;
		string name;
		string header;
		int authorID;
		DateTime date;
		string text;
		List<string> img;

		public Article()
		{
		}
	}
}
