Singleton Pattern belongs to creational design pattern.

 This pattern is used when we need to ensure only one object of a particular class need to be created.
 All further references to the object are referred to the same instances.

#Advantage:

        1)Singleton controls concurent access to the resource
        2)It ensures there is onlu one object available accross the application in a controlled state

#Implementation Guidelines:
        
        1)Ensure that only one instance of the class exists
        2)Provide global access to that instance by 
            a)Declaring all constructors of the class to be private
            b)Providing static method that returns a reference to the instance
            c)The instance is stored as a private static variable





#Lazy Loading:
        
        1) Improves the performance
        2)Avoid unnecessary load till the point object is accessed
        3)Reduces the memory foot print on the start up
        4)Faster application load

#Non-Lazy or Eager Loading:

        1)Pre-Instatiation of the object
        2)Commonly used in lower memory footprints.