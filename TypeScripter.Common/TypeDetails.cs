namespace TypeScripter.Common {
	public class TypeDetails {
		public string Name { get; private set; }
		public string Initializer { get; private set; }
		public bool UtcDate { get; set; }

		public TypeDetails(string name, string initializer = "") {
			Name = name;
			Initializer = initializer;
		}

		public override string ToString() {
			return Name;
		}
	}
}