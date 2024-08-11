using CompositionPrac;

Vest vest = new Vest();
Vegetable vegetable = new Vegetable(vest);
Flower flower = new Flower(vest);
vegetable.VegetableKeep();
flower.FlowerKeep();