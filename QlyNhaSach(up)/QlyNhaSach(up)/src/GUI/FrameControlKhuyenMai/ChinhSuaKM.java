package GUI.FrameControlKhuyenMai;

import java.awt.Cursor;
import javax.swing.BorderFactory;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.border.LineBorder;
import java.awt.Color;
import javax.swing.JLabel;
import java.awt.Font;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.Statement;
import javax.swing.JTextField;
import javax.swing.JButton;


public class ChinhSuaKM extends JFrame {
	private JTextField tfMaSach;
	private JTextField tfMucGiamGia;

	public ChinhSuaKM() {
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setSize(290, 187);
		setResizable(false);
		setLocationRelativeTo(null);
		getContentPane().setLayout(null);
		
		JPanel panel = new JPanel();
		panel.setBorder(new LineBorder(new Color(192, 192, 192), 1, true));
		panel.setBounds(10, 11, 264, 93);
		getContentPane().add(panel);
		panel.setLayout(null);
		
		JLabel lbMaSach = new JLabel("Mã sách");
		lbMaSach.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbMaSach.setBounds(10, 21, 53, 14);
		panel.add(lbMaSach);
		
		JLabel lbMucGiamGia = new JLabel("Mức giảm giá");
		lbMucGiamGia.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbMucGiamGia.setBounds(10, 58, 78, 15);
		panel.add(lbMucGiamGia);
		
		tfMaSach = new JTextField();
		tfMaSach.setEditable(false);
		tfMaSach.setBounds(94, 19, 160, 20);
		panel.add(tfMaSach);
		tfMaSach.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		
		tfMucGiamGia = new JTextField();
		tfMucGiamGia.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		tfMucGiamGia.setBounds(94, 56, 78, 20);
		panel.add(tfMucGiamGia);
		
		JLabel lb = new JLabel("%");
		lb.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lb.setBounds(182, 59, 21, 14);
		panel.add(lb);
		
		JButton bOK = new JButton("OK");
		bOK.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		bOK.setBounds(10, 109, 264, 38);
		bOK.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		bOK.setContentAreaFilled(false);
		getContentPane().add(bOK);
		
		bOK.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent arg0) {
			  try{
				  int mucgiamgia = Integer.valueOf(tfMucGiamGia.getText());
				  Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
				  String sql = String.format("UPDATE SACHKHUYENMAI SET MUCGIAMGIA = '%d' WHERE MASACH = '%s'",mucgiamgia,tfMaSach.getText());
					int n = statement.executeUpdate(sql);
					
					if(n==1){
						JOptionPane.showMessageDialog(null, "Chỉnh sửa thành công");
					}
				  
				  
			  }catch (Exception e) {
					e.printStackTrace();
				}
				
			}
		});
		
	}
	
	public void setMaSach(String masach){
		this.tfMaSach.setText(masach);
	}
	
	public static void main(String[] args) {
		new ChinhSuaKM().setVisible(true);
	}
}
