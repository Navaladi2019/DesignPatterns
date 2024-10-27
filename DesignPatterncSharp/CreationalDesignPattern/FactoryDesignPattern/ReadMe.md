
#Factory Design Pattern:

	Define an interface for creating an object, but let the sub classes decide which 
	class to instantiate. The factory method lets a class defer instantiation it uses to sub classses

Factory pattern creates object without exposing the creation logic to the client and refer
to the newly created object using a common interface


#Choosing Factory Pattern When:

	The object needs to be extended to sub classes
	The classes doesn't know what exact sub classes it has to create
	The product implementation tend to change overtime and the client remains unchanged

 