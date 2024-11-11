using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DesignPatterncSharp.Structural.Flyweight
{
    public class Oldtree
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public string LeafShape { set; get; }

        public int xPos { get; set; }

        public int yPos { get; set; }

    }

    public class OldGame
    {
        public List<Oldtree> OldtreeList { get; set; }

    }

    // from the above code we cn see that color, leafshape and type are intrinsic properties that do not change and
    // has extrinsic properties like xpos and ypos that changes inth game , that color , type and leafshape will take lot of space 


    // flyweight class
    public class TreeType
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public string LeafShape { set; get; }

       
    }

    public class Tree
    {

        public Tree(TreeType Type)
        {
            this.Type = Type;
        }

        public int xPos { get; set; }

        public int yPos { get; set; }

        public TreeType Type { get; set; }

        public void DrawTree(object canvas)
        {
            // drawing to canvas uysing tree type color, shape and x,y pos
        }
    }

    public class FlyWeightFactory
    {
        private List<TreeType> TreeTypes { get; set; } = new List<TreeType>();

        public TreeType GetTreeType(string name)
        {

            var tree= TreeTypes.FirstOrDefault(t => t.Name == name);
            if (tree ==null) { 
            
                // get from store and store it cache
            
            }

            return tree;
        }

       
    }

    public class Game
    {
        FlyWeightFactory flyWeightFactory;
        Game(FlyWeightFactory flyWeightFactory)
        {
            this.flyWeightFactory = flyWeightFactory;
        }
        public List<Tree> Trees { get; set; } = new List<Tree>();
        public object Canvas { get; set; }

        public void AddTree(string name)
        {
            var type = flyWeightFactory.GetTreeType(name);
            // here the typr is a refernce object so it will not create new memory for properties only the pointer for type
            var tree = new Tree(type);
            tree.DrawTree(Canvas);
            Trees.Add(tree);

        }

        // draw method can be moved here also based on our convinence
    }


}
