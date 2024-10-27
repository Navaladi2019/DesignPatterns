	- Use the Abstract Factory when your code needs to work with various families of related products, but you don’t want it to depend on the concrete classes of those products—they
		might be unknown beforehand or you simply want to allow for future extensibility.

	- In a well-designed program each class is responsible only for one thing. When a class deals with multiple product types, it may be worth extracting its factory methods into a stand-alone factory class or a full-blown Abstract Factory implementation.

	- Consider implementing the Abstract Factory when you have a class with a set of Factory Methods that blur its primary responsibility.