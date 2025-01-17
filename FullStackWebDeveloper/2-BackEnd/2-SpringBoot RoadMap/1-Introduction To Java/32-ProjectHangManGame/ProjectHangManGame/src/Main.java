import javafx.application.Application;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.layout.StackPane;
import javafx.stage.Stage;

public class JavaFXExample extends Application {
    @Override
    public void start(Stage primaryStage) {
        // Create a button and set an action on it
        Button btn = new Button("Click Me");
        btn.setOnAction(e -> System.out.println("Button Clicked!"));

        // Set up the layout and scene
        StackPane root = new StackPane();
        root.getChildren().add(btn);
        Scene scene = new Scene(root, 300, 200);

        // Set up and show the stage (window)
        primaryStage.setTitle("JavaFX Event-Driven Example");
        primaryStage.setScene(scene);
        primaryStage.show();
    }

    public static void main(String[] args) {
        launch(args);
    }
}
