package com.example.javafx_stages;

import eu.hansolo.fx.heatmap.ColorMapping;
import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.scene.image.Image;
import javafx.scene.image.ImageView;
import javafx.scene.input.KeyCombination;
import javafx.scene.paint.Color;
import javafx.stage.Stage;

import java.io.IOException;

public class HelloApplication extends Application {
    @Override
    public void start(Stage stage) throws IOException
    {
        //Stages is the frame or we can called it the windows application.
        //Scenes is the Components that Functions as a containers inside the Stage.
        //Groups/Roots is the components such as the text box, images,audio, etc.

        //To create an image use image class
        Image Icon = new Image("C:\\Users\\maher\\Desktop\\download.jpg");
        Group Root = new Group();
        Scene scene = new Scene(Root, Color.BLACK);
        stage.setScene(scene);
        stage.setTitle("Welcome to My Project in JavaFx");
        stage.getIcons().add(Icon);
        stage.setWidth(725);
        stage.setHeight(725);
        stage.setX(0);
        stage.setY(0);
        stage.setResizable(false);
        stage.setFullScreen(true);
        //To put a hint to exit the fill mode.
        stage.setFullScreenExitHint("Press Q to Exit the Full Mode.");
        //To choose the way to escape the full mode.
        stage.setFullScreenExitKeyCombination(KeyCombination.valueOf("Q"));
        //Stage stage = new Stage();
        stage.show();//To Show the Stage.

    }
    public static void main(String[] args)
    {
        launch(args);
    }
}