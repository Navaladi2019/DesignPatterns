
# In the open closed principle we have base employee class where temporary and permanent employee class
# have the common base class Employee.

# What if we have another class contract employee and inherits employee. If contact employee do not have 
# bonus then we end up implementing get bonus method which rsukt in new exception.

# Liskov Substitution principle states that base class should be entirely replaced by derived class and 
# no new exception should be raised by  the subtype.

# Since if we implement employee as base class for contact employee then we are violating error 
# so arrangement is made with interface,abstract and implementation.
