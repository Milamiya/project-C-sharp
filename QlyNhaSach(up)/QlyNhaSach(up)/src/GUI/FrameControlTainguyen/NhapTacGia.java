package GUI.FrameControlTainguyen;

import java.awt.Color;
import java.awt.Cursor;
import java.awt.EventQueue;
import java.awt.Toolkit;

import javax.swing.BorderFactory;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JLabel;
import java.awt.Font;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.sql.ResultSet;
import java.sql.Statement;
import javax.swing.border.TitledBorder;
import javax.swing.JTextField;
import javax.swing.JButton;


public class NhapTacGia extends JFrame {

	JTextField tfMaTacGia;
	JTextField tfTenTacGia;
	JTextField tfNamSinh;
	JTextField tfNamMat;
	JTextField tfQueQuan;

	public NhapTacGia() {
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setBounds(100, 100, 310, 290);
		getContentPane().setLayout(null);
		setIconImage(Toolkit.getDefaultToolkit().getImage(GUI.FrameControlCongcu.TimMaSach.class.getResource("/data/img/author.png")));
		setTitle("Nhập tác giả");
		setLocationRelativeTo(null);
		setResizable(false);
		
		JPanel panel = new JPanel();
		panel.setBorder(new TitledBorder(null, "Nh\u1EADp d\u1EEF li\u1EC7u", TitledBorder.LEADING, TitledBorder.TOP, null, null));
		panel.setBounds(10, 11, 284, 204);
		getContentPane().add(panel);
		panel.setLayout(null);
		
		JLabel lbMaTacGia = new JLabel("Mã tác giả");
		lbMaTacGia.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbMaTacGia.setEnabled(true);
		lbMaTacGia.setBounds(10, 23, 61, 15);
		panel.add(lbMaTacGia);
		
		JLabel lbTenTacGia = new JLabel("Tên tác giả");
		lbTenTacGia.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbTenTacGia.setEnabled(true);
		lbTenTacGia.setBounds(10, 58, 72, 15);
		panel.add(lbTenTacGia);
		
		JLabel lbNamSinh = new JLabel("Năm sinh");
		lbNamSinh.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbNamSinh.setEnabled(true);
		lbNamSinh.setBounds(10, 95, 61, 15);
		panel.add(lbNamSinh);
		
		JLabel lbNamMat = new JLabel("Năm mất");
		lbNamMat.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbNamMat.setEnabled(true);
		lbNamMat.setBounds(10, 132, 61, 15);
		panel.add(lbNamMat);
		
		JLabel lbQueQuan = new JLabel("Quê quán");
		lbQueQuan.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbQueQuan.setEnabled(true);
		lbQueQuan.setBounds(10, 170, 61, 15);
		panel.add(lbQueQuan);
		
		tfMaTacGia = new JTextField();
		tfMaTacGia.setBounds(91, 21, 47, 20);
		panel.add(tfMaTacGia);
		tfMaTacGia.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		
		tfTenTacGia = new JTextField();
		tfTenTacGia.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		tfTenTacGia.setBounds(91, 56, 183, 20);
		panel.add(tfTenTacGia);
		
		tfNamSinh = new JTextField();
		tfNamSinh.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		tfNamSinh.setBounds(91, 93, 72, 20);
		panel.add(tfNamSinh);
		
		tfNamMat = new JTextField();
		tfNamMat.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		tfNamMat.setBounds(91, 130, 72, 20);
		panel.add(tfNamMat);
		
		tfQueQuan = new JTextField();
		tfQueQuan.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		tfQueQuan.setBounds(91, 168, 183, 20);
		panel.add(tfQueQuan);
		
		JButton bReset = new JButton("Reset");
		bReset.setBounds(11, 217, 89, 37);
		bReset.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		bReset.setContentAreaFilled(false);
		getContentPane().add(bReset);
		
		JButton bOK = new JButton("OK");
		bOK.setBounds(109, 217, 89, 37);
		bOK.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		bOK.setContentAreaFilled(false);
		getContentPane().add(bOK);
		
		JButton bThoat = new JButton("Thoát");
		bThoat.setBounds(208, 217, 85, 37);
		bThoat.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		bThoat.setContentAreaFilled(false);
		getContentPane().add(bThoat);
		
        bThoat.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent arg0) {
				dispose();
			}
		});
		
		bReset.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				
				tfTenTacGia.setText("");
				tfMaTacGia.setText("");
				tfNamMat.setText("");
				tfNamSinh.setText("");
				tfQueQuan.setText("");

			}
		});
		
         tfMaTacGia.addMouseListener(new MouseListener() {
			
			@Override
			public void mouseReleased(MouseEvent arg0) {
				// TODO Auto-generated method stub
				
			}
			
			@Override
			public void mousePressed(MouseEvent arg0) {
				// TODO Auto-generated method stub
				
			}
			
			@Override
			public void mouseExited(MouseEvent arg0) {
                 try {
					
					String matacgia = tfMaTacGia.getText().toUpperCase();
					Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
					String sql = "SELECT MATACGIA FROM TACGIA";
					ResultSet rs = statement.executeQuery(sql);
					
					while(rs.next()){
						
						if(matacgia.equals(rs.getString("MATACGIA"))){
							JOptionPane.showMessageDialog(null,"Mã tác giả bị trùng","Thông báo",JOptionPane.ERROR_MESSAGE);
							tfMaTacGia.setText("");
						}
					}
				} catch (Exception e) {
					e.printStackTrace();
				}
				
			}
			
			@Override
			public void mouseEntered(MouseEvent arg0) {
				// TODO Auto-generated method stub
				
			}
			
			@Override
			public void mouseClicked(MouseEvent arg0) {
				// TODO Auto-generated method stub
				
			}
		});
		
		bOK.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent ev) {
				try {
					
					String matacgia = tfMaTacGia.getText();
					String tentacgia = tfTenTacGia.getText();
					String namsinh = tfNamSinh.getText();
					String nammat = tfNamMat.getText();
					String quequan = tfQueQuan.getText();
					
					if(tfNamSinh.getText().equals("")){
						namsinh = "NULL";
					}
					
					if(tfNamMat.getText().equals("")){
						nammat= "NULL";
					}
					
					if(tfQueQuan.getText().equals("")){
						quequan = "NULL";
					}

					Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
					String sql = String.format("INSERT INTO TACGIA VALUES ('%s','%s','%s','%s','%s')",matacgia.toUpperCase(),tentacgia.toUpperCase(),namsinh,nammat,quequan.toUpperCase());
					int n = statement.executeUpdate(sql);
					

					if(n == 1){
						JOptionPane.showMessageDialog(null,"Nhập tác giả thành công","Hoàn tất",JOptionPane.INFORMATION_MESSAGE);
					}
					
					else{
						JOptionPane.showMessageDialog(null,"Lỗi","Thông báo",JOptionPane.ERROR_MESSAGE);
					}

				} catch (Exception e) {
					e.printStackTrace();
				}
				
			}
		});
		
		tfMaTacGia.addMouseListener(new MouseListener() {
			
			@Override
			public void mouseReleased(MouseEvent arg0) {
				// TODO Auto-generated method stub
				
			}
			
			@Override
			public void mousePressed(MouseEvent arg0) {
				// TODO Auto-generated method stub
				
			}
			
			@Override
			public void mouseExited(MouseEvent arg0) {
                 try {
					
					String matacgia = tfMaTacGia.getText();
					
					if(matacgia.length()> 0 && matacgia.length()!= 4){
						JOptionPane.showMessageDialog(null,"Mã tác giả không đúng với quy định","Thông báo",JOptionPane.ERROR_MESSAGE);
						tfMaTacGia.setText("");
						tfMaTacGia.requestFocus();
					}
	
					Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
					String sql = "SELECT MATACGIA FROM TACGIA WHERE MATACGIA";
					ResultSet rs = statement.executeQuery(sql);
					
					while(rs.next()){
						
						if(matacgia.toUpperCase().equals(rs.getString("MATACGIA"))){
							JOptionPane.showMessageDialog(null,"Mã tác giả bị trùng","Thông báo",JOptionPane.ERROR_MESSAGE);
							tfMaTacGia.setText("");
							tfMaTacGia.requestFocus();
						}
					}
				} catch (Exception e) {
					e.printStackTrace();
				}
				
			}
			
			@Override
			public void mouseEntered(MouseEvent arg0) {
				// TODO Auto-generated method stub
				
			}
			
			@Override
			public void mouseClicked(MouseEvent arg0) {
				// TODO Auto-generated method stub
				
			}
		});
	}
	
	public void setTenTacGia (String tentg){
		this.tfTenTacGia.setText(tentg);
	}
	
	public static void main(String[] args) {
		new NhapTacGia().setVisible(true);
	}

}
