import javax.swing.*;
import java.awt.*;

public class Main {
    public static void main(String[] args)
    {
        //JPanel = a Gui component that functions as a container to hold other components.

        ImageIcon Image1 = new ImageIcon("img_1.png");
        Image1.setDescription("Black Hand");
        JLabel Label = new JLabel();
        Label.setText("Hi");
        Label.setForeground(Color.CYAN);
        Label.setIcon(Image1);
        Label.setBounds(0,0,150,150);
        Label.setHorizontalTextPosition(JLabel.RIGHT);
        Label.setVerticalAlignment(JLabel.TOP);
        JPanel RedPanel = new JPanel();
        RedPanel.setBackground(Color.red);
        RedPanel.setBounds(0,0,250,250);
        RedPanel.setLayout(null);//To put the picture the far left of the Frame Corner.

        JPanel GreenPanel = new JPanel();
        GreenPanel.setBackground(Color.green);
        GreenPanel.setBounds(250,0,250,250);

        JPanel BluePanel = new JPanel();
        BluePanel.setBackground(Color.blue);
        BluePanel.setBounds(0,250,500,250);

        JFrame Frame = new JFrame();
        Frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        Frame.setLayout(null);
        Frame.setSize(750,750);
        Frame.setVisible(true);

        RedPanel.add(Label);
        Frame.add(RedPanel);
        Frame.add(GreenPanel);
        Frame.add(BluePanel);
    }
}