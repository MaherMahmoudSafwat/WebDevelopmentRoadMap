import javax.swing.*;
import java.awt.*;

public class Main {
    public static void main(String[] args)
    {
        JFrame Frame = new JFrame();
        Frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        Frame.setVisible(true);
        Frame.setSize(700,700);
        Frame.getContentPane().setBackground(Color.darkGray);
        Frame.setTitle("My First Project");
        ImageIcon Image = new ImageIcon("img.png");
        Frame .setIconImage(Image.getImage());
        JLabel Label = new JLabel();
        Label.setText("Welcome to my quiz game.");
        Label.setForeground(Color.GREEN);
        Label.setIcon(Image);
        Label.setFont(new Font("",Font.ITALIC,23));
        Label.setHorizontalAlignment(JLabel.CENTER);
        Label.setVerticalAlignment(JLabel.TOP);
        Label.setHorizontalTextPosition(JLabel.CENTER);
        Label.setVerticalTextPosition(JLabel.TOP);
        Label.setIconTextGap(23);
        Frame.add(Label);
    }
}