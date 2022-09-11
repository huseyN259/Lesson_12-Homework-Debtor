﻿class Program
{
	class Debtor
	{
		public string? FullName { get; set; }
		public DateTime BirthDay { get; set; }
		public string? Phone { get; set; }
		public string? Email { get; set; }
		public string? Address { get; set; }
		public int Debt { get; set; }

		public Debtor(string fullname, DateTime birthDay, string phone, string email, string address, int debt)
		{
			this.FullName = fullname;
			this.BirthDay = birthDay;
			this.Phone = phone;
			this.Email = email;
			this.Address = address;
			this.Debt = debt;
		}
		
		public override string ToString()
		{
			return $"{this.FullName} {this.BirthDay.ToShortDateString()} {this.Phone} {this.Email} {this.Address} {this.Debt}";
		}
	}

	static List<Debtor> debtors = new List<Debtor> 
	{
		new Debtor("Huseyn I. Nuran", DateTime.Parse("May 25, 2003"), "259-925-2509", "hsynnrn@gmail.com", "Baku City, UTC 25909", 925),
		new Debtor("Trafalgar D. Law", DateTime.Parse("March 21, 1990"), "123-456-7890", "DLaw@jourrapide.com", "Grand Line City, UT 84104", 8808),
		new Debtor("Shirley T. Qualls", DateTime.Parse("March 30, 1932"), "530-662-7732", "ShirleyTQualls@teleworm.us", "3565 Eagles Nest Drive Woodland, CA 95695", 2414),
		new Debtor("Danielle W. Grier", DateTime.Parse("October 18, 1953"), "321-473-4178", "DanielleWGrier@rhyta.com", "1973 Stoneybrook Road Maitland, FL 32751", 3599),
		new Debtor("Connie W. Lemire", DateTime.Parse("June 18, 1963"), "828-321-3751", "ConnieWLemire@rhyta.com", "2432 Hannah Street Andrews, NC 28901", 1219),
		new Debtor("Coy K. Adams", DateTime.Parse("March 1, 1976"), "410-347-1307", "CoyKAdams@dayrep.com", "2411 Blue Spruce Lane Baltimore, MD 21202", 3784),
		new Debtor("Bernice J. Miles", DateTime.Parse("June 1, 1988"), "912-307-6797", "BerniceJMiles@armyspy.com", "4971 Austin Avenue Savannah, GA 31401", 4060),
		new Debtor("Bob L. Zambrano", DateTime.Parse("February 28, 1990"), "706-446-1649", "BobLZambrano@armyspy.com", "2031 Limer Street Augusta, GA 30901", 6628),
		new Debtor("Adam D. Bartlett", DateTime.Parse("May 6, 1950"), "650-693-1758", "AdamDBartlett@rhyta.com", "2737 Rardin Drive San Jose, CA 95110", 5412),
		new Debtor("Pablo M. Skinner", DateTime.Parse("August 26, 1936"), "630-391-2034", "PabloMSkinner@armyspy.com", "16 Fraggle Drive Hickory Hills, IL 60457", 11097),
		new Debtor("Dorothy J. Brown", DateTime.Parse("July 9, 1971"), "270-456-3288", "DorothyJBrown@rhyta.com", "699 Harper Street Louisville, KY 40202", 7956),
		new Debtor("Larry A. Miracle", DateTime.Parse("May 22, 1998"), "301-621-3318", "LarryAMiracle@jourrapide.com", "2940 Adams Avenue Columbia, MD 21044", 7150),
		new Debtor("Donna B. Maynard", DateTime.Parse("January 26, 1944"), "520-297-0575", "DonnaBMaynard@teleworm.us", "4821 Elk Rd Little Tucson, AZ 85704", 2910),
		new Debtor("Jessica J. Stoops", DateTime.Parse("April 22, 1989"), "360-366-8101", "JessicaJStoops@dayrep.com", "2527 Terra Street Custer, WA 98240", 11805),
		new Debtor("Audry M. Styles", DateTime.Parse("February 7, 1937"), "978-773-4802", "AudryMStyles@jourrapide.com", "151 Christie Way Marlboro, MA 01752", 1001),
		new Debtor("Violet R. Anguiano", DateTime.Parse("November 4, 1958"), "585-340-7888", "VioletRAnguiano@dayrep.com", "1460 Walt Nuzum Farm Road Rochester, NY 14620", 9128),
		new Debtor("Charles P. Segundo", DateTime.Parse("October 21, 1970"), "415-367-3341", "CharlesPSegundo@dayrep.com", "1824 Roosevelt Street Fremont, CA 94539", 5648),
		new Debtor("Paul H. Sturtz", DateTime.Parse("September 15, 1944"), "336-376-1732", "PaulHSturtz@dayrep.com", "759 Havanna Street Saxapahaw, NC 27340", 10437),
		new Debtor("Doris B. King", DateTime.Parse("October 10, 1978"), "205-231-8973", "DorisBKing@rhyta.com", "3172 Bedford Street Birmingham, AL 35203", 7230),
		new Debtor("Deanna J. Donofrio", DateTime.Parse("April 16, 1983"), "952-842-7576", "DeannaJDonofrio@rhyta.com", "1972 Orchard Street Bloomington, MN 55437", 515),
		new Debtor("Martin S. Malinowski", DateTime.Parse("January 17, 1992"), "765-599-3523", "MartinSMalinowski@dayrep.com", "3749 Capitol Avenue New Castle, IN 47362", 1816),
		new Debtor("Melissa R. Arner", DateTime.Parse("May 24, 1974"), "530-508-7328", "MelissaRArner@armyspy.com", "922 Hill Croft Farm Road Sacramento, CA 95814", 5037),
		new Debtor("Kelly G. Hoffman", DateTime.Parse("September 22, 1969"), "505-876-8935", "KellyGHoffman@armyspy.com", "4738 Chapmans Lane Grants, NM 87020", 7755),
		new Debtor("Doyle B. Short", DateTime.Parse("June 15, 1986"), "989-221-4363", "DoyleBShort@teleworm.us", "124 Wood Street Saginaw, MI 48607", 11657),
		new Debtor("Lorrie R. Gilmore", DateTime.Parse("December 23, 1960"), "724-306-7138", "LorrieRGilmore@teleworm.us", "74 Pine Street Pittsburgh, PA 15222", 9693),
		new Debtor("Lionel A. Cook", DateTime.Parse("April 16, 1972"), "201-627-5962", "LionelACook@jourrapide.com", "29 Goldleaf Lane Red Bank, NJ 07701", 2712),
		new Debtor("Charlene C. Burke", DateTime.Parse("January 18, 1990"), "484-334-9729", "CharleneCBurke@armyspy.com", "4686 Renwick Drive Philadelphia, PA 19108", 4016),
		new Debtor("Tommy M. Patton", DateTime.Parse("June 30, 1981"), "774-571-6481", "TommyMPatton@rhyta.com", "748 Rockford Road Westborough, MA 01581", 349),
		new Debtor("Kristin S. Bloomer", DateTime.Parse("June 16, 1944"), "443-652-0734", "KristinSBloomer@dayrep.com", "15 Hewes Avenue Towson, MD 21204", 9824),
		new Debtor("Daniel K. James", DateTime.Parse("November 10, 1997"), "801-407-4693", "DanielKJames@rhyta.com", "3052 Walton Street Salt Lake City, UT 84104", 8215),
		new Debtor("Paula D. Henry", DateTime.Parse("September 6, 1976"), "618-378-5307", "PaulaDHenry@rhyta.com", "3575 Eagle Street Norris City, IL 62869", 5766),
		new Debtor("Donna C. Sandoval", DateTime.Parse("December 13, 1947"), "540-482-5463", "DonnaCSandoval@rhyta.com", "675 Jehovah Drive Martinsville, VA 24112", 8363),
		new Debtor("Robert T. Taylor", DateTime.Parse("August 17, 1932"), "270-596-6442", "RobertTTaylor@armyspy.com", "2812 Rowes Lane Paducah, KY 42001", 7785),
		new Debtor("Donna W. Alamo", DateTime.Parse("December 9, 1948"), "978-778-2533", "DonnaWAlamo@teleworm.us", "4367 Christie Way Marlboro, MA 01752", 10030),
		new Debtor("Amy R. Parmer", DateTime.Parse("May 19, 1995"), "480-883-4934", "AmyRParmer@armyspy.com", "85 Elmwood Avenue Chandler, AZ 85249", 5347),
		new Debtor("Newton K. Evans", DateTime.Parse("October 8, 1986"), "303-207-9084", "NewtonKEvans@rhyta.com", "3552 Columbia Road Greenwood Village, CO 80111", 9838),
		new Debtor("Kathleen C. Chaney", DateTime.Parse("January 5, 1949"), "605-245-3513", "KathleenCChaney@rhyta.com", "316 Elsie Drive Fort Thompson, SD 57339", 1672),
		new Debtor("Manuel C. Johnson", DateTime.Parse("February 23, 1957"), "606-247-2659", "ManuelCJohnson@jourrapide.com", "4146 May Street Sharpsburg, KY 40374", 9195),
		new Debtor("Carla A. Creagh", DateTime.Parse("November 21, 1988"), "614-307-8974", "CarlaACreagh@dayrep.com", "3106 Bates Brothers Road Columbus, OH 43215", 11271),
		new Debtor("Norma M. New", DateTime.Parse("May 18, 1988"), "857-492-8703", "NormaMNew@jourrapide.com", "965 Metz Lane Woburn, MA 01801", 9761),
		new Debtor("Roy D. Green", DateTime.Parse("January 27, 1983"), "308-340-5981", "RoyDGreen@jourrapide.com", "401 Romrog Way Grand Island, NE 68801", 10771),
		new Debtor("Cristy J. Jensen", DateTime.Parse("November 2, 1935"), "440-626-9550", "CristyJJensen@jourrapide.com", "2177 Harley Vincent Drive Cleveland, OH 44113", 5205),
		new Debtor("Nancy J. Fergerson", DateTime.Parse("June 10, 1993"), "219-987-8498", "NancyJFergerson@dayrep.com", "3584 Jadewood Drive Demotte, IN 46310", 1276),
		new Debtor("Dave N. Rodriguez", DateTime.Parse("January 21, 1938"), "214-540-2499", "DaveNRodriguez@rhyta.com", "1890 Poco Mas Drive Dallas, TX 75247", 9132),
		new Debtor("James E. Denning", DateTime.Parse("May 4, 1988"), "504-289-8640", "JamesEDenning@jourrapide.com", "1444 Rose Avenue Metairie, LA 70001", 8176),
		new Debtor("Richard M. Thomas", DateTime.Parse("February 13, 1972"), "510-735-3359", "RichardMThomas@jourrapide.com", "4454 Green Avenue Oakland, CA 94609", 7875),
		new Debtor("Lakisha R. Forrest", DateTime.Parse("December 1, 1973"), "334-830-1181", "LakishaRForrest@armyspy.com", "3121 Quarry Drive Montgomery, AL 36117", 3088),
		new Debtor("Pamela H. Beauchamp", DateTime.Parse("November 20, 1959"), "801-559-6347", "PamelaHBeauchamp@jourrapide.com", "3239 Tori Lane Salt Lake City, UT 84104", 6588)
	};

	static void Main()
	{
		// 2) rhyta.com ve ya dayrep.com domenlerinde emaili olan borclulari cixartmag

		/*debtors.Where(d => d.Email.EndsWith("rhyta.com") || d.Email.EndsWith("dayrep.com")).Print();

		foreach(var debtor in debtors)
			if (debtor.Email.EndsWith("rhyta.com") || debtor.Email.EndsWith("dayrep.com"))
				Console.WriteLine(debtor);*/


		// 3) Yashi 26 - dan 36 - ya qeder olan borclulari cixartmag

		/*byte CalculateAge(DateTime birthday) => Convert.ToByte(DateTime.Now.Year - birthday.Year);
		debtors.Where(d => { byte age = CalculateAge(d.BirthDay); return age >= 26 && age < 36; }).Print();

		foreach (var debtor in debtors)
		{
			byte age = Convert.ToByte(DateTime.Now.Year - debtor.BirthDay.Year);
			if (age >= 26 && age < 36)
				Console.WriteLine(debtor);
		}*/


		// 4) Borcu 5000 - den cox olmayan borclularic cixartmag

		/*debtors.Where(d => d.Debt < 500).Print();

		foreach (var debtor in debtors)
			if (debtor.Debt < 5000)
				Console.WriteLine(debtor);*/


		// 5) Butov adi 18 simvoldan cox olan ve telefon nomresinde 2 ve ya 2 - den cox 7 reqemi olan borclulari cixartmaq

		/*debtors.Where(d => d.FullName.Length > 18 && d.Phone.Count(c => c == '7') >= 2).Print();

		foreach (var debtor in debtors)
			if (debtor.FullName.Length > 18 && debtor.Phone.Count(c => c == '7') >= 2)
				Console.WriteLine(debtor);*/


		// 7) Qishda anadan olan borclulari cixardmaq

		/*debtors.Where(d => d.BirthDay.Month <= 2 || d.BirthDay.Month == 12).Print();

		foreach (var debtor in debtors)
			if (debtor.BirthDay.Month <= 2 || debtor.BirthDay.Month == 12)
				Console.WriteLine(debtor);*/


		// 8) Borcu, umumi borclarin orta borcunnan cox olan borclulari cixarmaq ve evvel familyaya gore, sonra ise meblegin azalmagina gore sortirovka etmek

		/*double averageDebt = debtors.Average(debtor => debtor.Debt);
		Console.WriteLine($"Average of Debt: {averageDebt}");
		var aboveAverageList = debtors.Where(d => d.Debt > averageDebt).ToList();
		aboveAverageList.Print();
		
		Console.WriteLine("\n");
		aboveAverageList.OrderBy(d => d.FullName.Substring(d.FullName.LastIndexOf(' ') + 1)).ToList().Print();
		Console.WriteLine("\n");
		aboveAverageList.OrderByDescending(d => d.Debt).ToList().Print();*/


		// 9) Telefon nomresinde 8 olmayan borclularin yalniz familyasin, yashin ve umumi borcun meblegin cixarmaq

		/*debtors.Where(d => !d.Phone.Contains('8')).Print();

		foreach (var debtor in debtors)
			if (!debtor.Phone.Contains('8'))
				Console.WriteLine($"{debtor.FullName.Substring(debtor.FullName.LastIndexOf(' '))} {DateTime.Now.Year - debtor.BirthDay.Year} {debtor.Debt} {debtor.Phone}");*/


		// 11) Adinda ve familyasinda hec olmasa 3 eyni herf olan borclularin siyahisin cixarmaq ve onlari elifba sirasina gore sortirovka elemek

		/*static bool ExistMoreCount(string text, int minSameCount = 2)
		{
			foreach (char c in text)
				if (text.Count(ch => ch == c) > minSameCount)
					return true;

			return false;
		}

		debtors.Where(d => ExistMoreCount(d.FullName, 3)).Print();*/


		// 13) Borclulardan en coxu hansi ilde dogulubsa hemin ili cixartmaq

		/*var dict = debtors.ToLookup(d => d.BirthDay.Year);
		var maxCount = dict.Max(c => c.Count());
		Console.Write($"{maxCount} number - ");
		dict.Where(d => d.Count() == maxCount).Select(s => s.Key).Print();*/


		// 14)Borcu en boyuk olan 5 borclunun siyahisini cixartmaq

		//debtors.OrderByDescending(d => d.Debt).Take(5).Print();


		// 15)Butun borcu olanlarin borcunu cemleyib umumi borcu cixartmaq

		//Console.WriteLine(debtors.Sum(d => d.Debt));


		// 16)2ci dunya muharibesin gormush borclularin siyahisi cixartmaq

		/*debtors.Where(d => d.BirthDay.Year >= 1945).Print();

		foreach (var debtor in debtors)
			if (debtor.BirthDay.Year <= 1945)
				Console.WriteLine(debtor);*/


		// 18)Nomresinde tekrar reqemler olmayan borclularin ve onlarin borcunun meblegin cixartmaq

		/*Predicate<string> numberIsUnique = number =>
		{
			foreach (var element in number)
				if (element != '-' && number.Count(n => n == element) != 1)
					return false;

			return true;
		};

		debtors.Where(d => numberIsUnique(d.Phone)).Print();*/


		// 19)Tesevvur edek ki,butun borclari olanlar bugunden etibaren her ay 500 azn pul odeyecekler.Oz ad gunune kimi borcun oduyub qurtara bilenlerin siyahisin cixartmaq

		/*Func<DateTime, DateTime> calculateBirthday = dt =>
		{
			dt = dt.AddYears(DateTime.Now.Year - dt.Year);
			var span = dt - DateTime.Now;
			
			if (span < TimeSpan.Zero) 
				dt = dt.AddYears(1);

			return dt;
		};
		
		debtors.Where(d => d.Debt - (calculateBirthday(d.BirthDay) - DateTime.Now).TotalDays * 500 <= 0).Print();*/


		// 20)Adindaki ve familyasindaki herflerden "smile" sozunu yaza bileceyimiz borclularin siyahisini cixartmaq

		/*Func<string, string, bool> isContains = (main, text) =>
		{
			foreach (var character in text)
				if (!main.Contains(character))
					return false;
			
			return true;
		};

		debtors.Where(d => isContains(d.FullName.ToLower(), "smile")).Print();

		foreach (var debtor in debtors)
			if (isContains(debtor.FullName.ToLower(), "smile"))
				Console.WriteLine(debtor);*/
	}
}