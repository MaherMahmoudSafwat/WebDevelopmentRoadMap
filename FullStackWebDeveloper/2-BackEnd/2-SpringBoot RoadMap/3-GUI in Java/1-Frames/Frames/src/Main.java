import javax.swing.JFrame; //Call this library to create a JFrame.
import javax.swing.ImageIcon;//Call this library to create an image.
import java.awt.*;

public class Main {
    public static void main(String[] args)
    {
       /* //JFrame is a GUI Windows used to add a components in it.
        JFrame Frame = new JFrame();
        Frame.setTitle("My First Project in GUI");//To set the title of the Frame.
        Frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);//To exit out of the application.
        //Frame.setDefaultCloseOperation(JFrame.DO_NOTHING_ON_CLOSE);//It will continue to open.
        Frame.setResizable(false);//Prevent the application windows from being resized.
        Frame.setSize(420,420);//To set the size of the Frame.
        Frame.setVisible(true);//To Show to frame to you inside the windows.

        ImageIcon Image = new ImageIcon("img.png");//Create an ImageIcon.
        Frame.setIconImage(Image.getImage());//To Set a new icon for the application instead of default icon which is java.
        Frame.getContentPane().setBackground(new Color(23,123,237));//To change the colour background.
        //Frame.getContentPane().setBackground(new Color(0xFFFFF9));//You can also use hexadecimal.*/
        //NewFrame Frame = new NewFrame();If you want to make some methods or make some work inside it.
        new NewFrame();
    }
}