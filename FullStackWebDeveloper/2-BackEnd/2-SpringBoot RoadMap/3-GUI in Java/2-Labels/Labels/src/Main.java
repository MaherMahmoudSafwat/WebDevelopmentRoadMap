import javax.swing.*;
import javax.swing.border.Border;
import java.awt.*;

public class Main {
    public static void main(String[] args)
    {
        JLabel Label = new JLabel();//To create a label in which we will use it to add components inside the frame.
        Border border = BorderFactory.createLineBorder(Color.GREEN,5);//To create borders of the frame.
        //----
        //|  |
        //----
        ImageIcon Image = new ImageIcon("img.png");
        Label.setText("Welcome to java");//To set text inside the frame.
        Label.setIcon(Image);
        Label.setHorizontalTextPosition(JLabel.HORIZONTAL);//To set text inside Position the frame.
        Label.setVerticalTextPosition(JLabel.EAST);
        Label.setForeground(new Color(0,0,0));//Set Color of the text
        Label.setForeground(Color.BLUE);
        Label.setFont(new Font("MV Boli",Font.ITALIC,20));
        Label.setIconTextGap(125);//To set the gap between icon and text.
        Label.setBackground(Color.black);//To set the color of the frame Background.
        Label.setOpaque(true);//To Display new Background frame colour.
        Label.setBorder(border);
        Label.setVerticalAlignment(JLabel.CENTER);//Set the Alignment of label image + text on Y-Axis.
        Label.setHorizontalAlignment(JLabel.CENTER);//Set the alignment on X-Axis.
        Label.setBounds(100,100,200,300);//Set the Bounds.
        JFrame Frame = new JFrame();
        //Frame.setSize(500,500);
        Frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        Frame.setVisible(true);
        Frame.add(Label);
        Frame.pack();//Set the Frame and labels according to its default Size.
    }
}