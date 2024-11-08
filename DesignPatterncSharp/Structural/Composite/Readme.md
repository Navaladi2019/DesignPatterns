- A tree structure of simple and composite objects
- Compose objects into tree structures to represent whole-part hierarchies. Composite lets clients treat individual objects and compositions of objects uniformly.
- Recursive composition
-- here each object is considered as it own and parent will call the child to get results
-  i have implemented rule engine ,based on the composite design pattern.
- There also i am planning to use bridge design patten



consider having a box that contain many box and items we need to extract price, one way to do it extract all products and compute price or treat each  as indivudual obect and compute price


consider we have to search through folder , a folder will have many folder and that will have many and so on.


interface Finder{

bool HasWord(strinfg Name);

}

class Folder : Finder
{


string Name;


public List<Finder> child{get;set;}

bool HasWord(string name){

if this.Name == name{

return true;
}

foreach f in child{
if child.HasWord(wname){
return true
}
}

return false
}

}

// here files is a leaf so it will not have child
class File : Finder{


string Name;
string content;


bool HasWord(string name){

if this.Name == name{

return true;
}


return content.contains(word);

}



}