﻿/// <summary>
/// Creates an instance of several families of classes.
/// 
/// Provide an interface for creating families of related or
/// dependent objects without specifying their concrete classes.
/// 
/// Frequence of use: 5 high.
/// </summary>
namespace DoFactory.GangOfFour.Abstract.RealWorld
{
    /// <summary>
    /// The 'AbstractFactory' abstract class
    /// </summary>
    abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
}