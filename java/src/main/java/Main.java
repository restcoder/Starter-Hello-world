import java.net.URI;
import java.net.URISyntaxException;
import com.google.gson.Gson;

import static spark.Spark.*;
import static spark.Spark.get;

class HelloMessage {
  public final String hello = "world";
}

public class Main {

  public static void main(String[] args) {
    port(Integer.valueOf(System.getenv("PORT")));
    Gson gson = new Gson();

    get("/hello", (req, res) -> "world");

    get("/hello-json", (req, res) -> {
        res.type("application/json");
        return new HelloMessage();
    }, gson::toJson);

    awaitInitialization();
    System.out.println("READY");
  }
}