
- Bridge Pattern decouples abstraction from implementation so that both can vary independently

- in the below expmple we ermoved tight coupling by extracting the interface called breather and implemented different breathing


consider class Living beings


abstract class LivigBeings{

abstract void Breathe();

}

class human : LivingBeings{

void Overide breathe(){

//ihale through nose
exchale co2
}

}

class deer : LivingBeings{

void Overide breathe(){

//ihale through nose
exchale co2
}

}

class Fish : LivingBeings{

void Overide breathe(){

//ihale through Gills
exchale co2
}

}

class Tree : LivingBeings{

void Overide breathe(){

//ihale through Leaf
exchale co2
}

}


if we see from the above code we are repeating the same logic for both human and deer and the breath process is tightly coupled on implementation


suppose we have breather interface

<Implementer>
interface breather{
 void breathe();

}

<Concrete Impelmenter>

class Nosebreather : breather{
 void breathe(){

// inhale through nose
}

}


class Gillsbreather : breather{
 void breathe(){

// inhale through Gills
}

}

class narsalbreather : breather{
 void breathe(){

// inhale through Narsal
}

}
class Leafbreather : breather{
 void breathe(){

// inhale through Leaf
}

}


abstract class LivigBeings{

constructor(breather breather){
}

abstract void Breathe();

}

class human : LivingBeings{

void Overide breathe(){

breather.Breathe()
}

}

class deer : LivingBeings{

void Overide breathe(){

breather.Breathe()
}

}

class Fish : LivingBeings{

void Overide breathe(){

breather.Breathe()
}

}

class Tree : LivingBeings{

void Overide breathe(){

breather.Breathe()
}

}


living being = new Fish(new GillsBreather());
living being = new Tree(new LeafBreather());