public class FamilyMember {
    private String name;
    private int age;
    public FamilyMember next;

    public FamilyMember(){
    this.name="";
     this.age= 0;
    this.next= null;

    }
    public FamilyMember(String name, int age){
        this.name= name;
        this.age= age;
        this.next= null;
    }

    public FamilyMember(String name, int age, FamilyMember next){
         this.name= name;
         this.age= age;
        this.next= null;
        }

        public void setname(String name){
        this.name= name;
        }

         public String getName(){
            return name;
        }
        public void setAge(int age){
           this.age= age;
        }
        public int getAge(){
            return age;
        }

        

}
