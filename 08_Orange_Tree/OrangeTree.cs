using System;

namespace _08_Orange_Tree
{
    internal class OrangeTree{

        private int age;
        private int height;
        private bool treeAlive = true;
        private int numOranges;
        private bool flip = false;
        private int orangesEaten;

        public int Age{

            get{
                return age;
            }
            set{
                age = value;
            }
        }
        public int Height{

            get{
                return height;
            }
            set{
                height = value;
            }
        }
        public bool TreeAlive{

            get{
                return treeAlive;
            }
            set{
                treeAlive = value;
            }
        }

        public int NumOranges{

            get{
                return numOranges;
            }
            set{
                numOranges = value;
            }
        }

        public int OrangesEaten{

            get{
                return orangesEaten;
            }
            set{
                orangesEaten = value;
            }
        }

        public OrangeTree(int v1, int v2){

            Age = v1;
            Height = v2;
        }

        public void OneYearPasses(){

            Age++;
            Height += 2;
            if(Age == 80){
                TreeAlive = false;
            }
            if (Age > 2){
                NumOranges += 5;
            }
            else{
                if (Age > 0 && flip){
                    NumOranges += 5;
                    flip = false;
                }
                else{
                    flip = true;
                }
            }
        }

        public void EatOrange(int v){

            OrangesEaten += v;
            NumOranges -= v;
            if(NumOranges < 0){
                NumOranges += v;
                throw new IndexOutOfRangeException("You can't eat an orange that isn't there!  There are 0 oranges available to eat");
            }
        }
    }
}