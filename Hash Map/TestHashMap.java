public class TestHashMap {

    public static void main(String[] args) {
        HashMap test = new HashMap(7);

        test.put("Name", "Anna");
        test.put("Age", "19");
        test.put("Gender", "Female");
        test.put("Address", "Bacolod");
        

        System.out.println("******** PRINT ALL *********");

        System.out.println("Get First Name: " + test.get("Name"));
        System.out.println("Get Age: " + test.get("Age"));
        System.out.println("Get Gender: " + test.get("Gender"));
        System.out.println("Get Address: " + test.get("Address"));
            test.printAll();


    }
}