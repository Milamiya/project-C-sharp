package GUI.FrameControlTainguyen;

//import .*;
import java.awt.Color;
import java.awt.Cursor;
import java.awt.EventQueue;
import java.awt.Toolkit;

import javax.swing.BorderFactory;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.SwingUtilities;
import javax.swing.border.TitledBorder;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;
import javax.swing.JLabel;
import java.awt.Font;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import java.sql.ResultSet;
import java.sql.Statement;
import javax.swing.JTextField;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.border.LineBorder;

public class KhaiBaoSach extends JFrame {
	private JTextField tfMaSach;
	private JTextField tfTenSach;
	private JTextField tfTenTacGia;
	private JTextField tfLanTB;
	private JTextField tfNamXB;
	private JTextField tfGiaBia;
	private JTextField tfNhaXB;
	JButton bKhaiBao;
	JLabel lbMaLoaiSach, lbMaTacGia, lbMaLinhVuc;
	private JComboBox cbMaTacGia;
	private JComboBox cbMaLoaiSach;
	private JComboBox cbMaLinhVuc;
	private JTextField tfMaTacGia;
	private JTextField tfMaLoaiSach;
	private JTextField tfMaLinhVuc;
	private JTextField tfGiaNhap;

	public KhaiBaoSach() {
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setIconImage(Toolkit.getDefaultToolkit().getImage(GUI.Login.class.getResource("/data/img/kb.png")));
		setBounds(100, 100, 617, 288);
		getContentPane().setLayout(null);
		setTitle("Khai báo thông tin sách");
		setLocationRelativeTo(null);
		setResizable(false);

		JPanel p1 = new JPanel();
		p1.setBorder(new TitledBorder(new LineBorder(new Color(192, 192, 192)), "Th\u00F4ng tin s\u00E1ch", TitledBorder.LEADING, TitledBorder.TOP, null, null));
		p1.setBounds(10, 11, 308, 233);
		getContentPane().add(p1);
		p1.setLayout(null);

		JLabel lbMaSach = new JLabel("Mã sách");
		lbMaSach.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbMaSach.setBounds(10, 23, 53, 15);
		p1.add(lbMaSach);

		JLabel lbTenSach = new JLabel("Tên sách");
		lbTenSach.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbTenSach.setBounds(10, 59, 58, 15);
		p1.add(lbTenSach);

		JLabel lbTenTacGia = new JLabel("Tên tác giả");
		lbTenTacGia.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbTenTacGia.setBounds(10, 95, 65, 15);
		p1.add(lbTenTacGia);

		tfMaSach = new JTextField();
		tfMaSach.setBounds(83, 21, 206, 20);
		p1.add(tfMaSach);
		tfMaSach.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));

		tfTenSach = new JTextField();
		tfTenSach.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		tfTenSach.setBounds(83, 57, 206, 20);
		p1.add(tfTenSach);

		tfTenTacGia = new JTextField();
		tfTenTacGia.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		tfTenTacGia.setBounds(83, 93, 206, 20);
		p1.add(tfTenTacGia);
		
		lbMaTacGia = new JLabel("Mã tác giả");
		lbMaTacGia.setBounds(10, 131, 72, 15);
		p1.add(lbMaTacGia);
		lbMaTacGia.setFont(new Font("Times New Roman", Font.PLAIN, 14));
				
		lbMaLoaiSach = new JLabel("Mã loại sách");
		lbMaLoaiSach.setBounds(10, 167, 72, 15);
		p1.add(lbMaLoaiSach);
		lbMaLoaiSach.setFont(new Font("Times New Roman", Font.PLAIN, 14));
						
		lbMaLinhVuc = new JLabel("Mã lĩnh vực");
		lbMaLinhVuc.setBounds(10, 203, 73, 15);
		p1.add(lbMaLinhVuc);
		lbMaLinhVuc.setFont(new Font("Times New Roman", Font.PLAIN, 14));
								
		tfMaTacGia = new JTextField();
		tfMaTacGia.setEditable(false);
		tfMaTacGia.setBounds(83, 129, 65, 20);
		p1.add(tfMaTacGia);
		tfMaTacGia.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
								
		tfMaLoaiSach = new JTextField();
		tfMaLoaiSach.setEditable(false);
		tfMaLoaiSach.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		tfMaLoaiSach.setBounds(83, 165, 65, 20);
		p1.add(tfMaLoaiSach);
								
		tfMaLinhVuc = new JTextField();
		tfMaLinhVuc.setEditable(false);
		tfMaLinhVuc.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		tfMaLinhVuc.setBounds(83, 201, 65, 20);
		p1.add(tfMaLinhVuc);
								
		cbMaTacGia = new JComboBox();
		cbMaTacGia.setBounds(168, 128, 61, 23);
		p1.add(cbMaTacGia);
										
	    cbMaLoaiSach = new JComboBox();
		cbMaLoaiSach.setBounds(168, 164, 61, 23);
		p1.add(cbMaLoaiSach);
												
		cbMaLinhVuc = new JComboBox();
		cbMaLinhVuc.setBounds(168, 200, 61, 23);
		p1.add(cbMaLinhVuc);

		JPanel p3 = new JPanel();
		p3.setBorder(new TitledBorder(new LineBorder(new Color(192, 192, 192)), "Th\u00F4ng tin xu\u1EA5t b\u1EA3n", TitledBorder.LEADING, TitledBorder.TOP, null, null));
		p3.setBounds(321, 11, 283, 194);
		getContentPane().add(p3);
		p3.setLayout(null);

		JLabel lbLanTB = new JLabel("Lần tái bản");
		lbLanTB.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbLanTB.setBounds(10, 26, 67, 14);
		p3.add(lbLanTB);

		JLabel lbNamXB = new JLabel("Năm xuất bản");
		lbNamXB.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbNamXB.setBounds(10, 60, 79, 14);
		p3.add(lbNamXB);

		JLabel lbGiaBia = new JLabel("Giá bìa");
		lbGiaBia.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbGiaBia.setBounds(10, 97, 53, 14);
		p3.add(lbGiaBia);

		JLabel lbNhaXB = new JLabel("Nhà xuất bản");
		lbNhaXB.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbNhaXB.setBounds(10, 131, 79, 17);
		p3.add(lbNhaXB);

		tfLanTB = new JTextField();
		tfLanTB.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		tfLanTB.setBounds(98, 24, 53, 20);
		p3.add(tfLanTB);

		tfNamXB = new JTextField();
		tfNamXB.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		tfNamXB.setBounds(98, 58, 67, 20);
		p3.add(tfNamXB);

		tfGiaBia = new JTextField();
		tfGiaBia.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		tfGiaBia.setBounds(98, 95, 91, 20);
		p3.add(tfGiaBia);

		tfNhaXB = new JTextField();
		tfNhaXB.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		tfNhaXB.setBounds(98, 130, 131, 20);
		p3.add(tfNhaXB);
		
		JLabel lbGiaNhap = new JLabel("Giá nhập");
		lbGiaNhap.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbGiaNhap.setBounds(10, 165, 53, 14);
		p3.add(lbGiaNhap);
		
		tfGiaNhap = new JTextField();
		tfGiaNhap.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		tfGiaNhap.setBounds(98, 165, 131, 20);
		p3.add(tfGiaNhap);

		bKhaiBao = new JButton("Khai báo");
		bKhaiBao.setBounds(322, 205, 89, 38);
		bKhaiBao.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		bKhaiBao.setContentAreaFilled(false);
		getContentPane().add(bKhaiBao);

		JButton bReset = new JButton("Reset");
		bReset.setBounds(420, 205, 89, 38);
		bReset.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		bReset.setContentAreaFilled(false);
		getContentPane().add(bReset);

		JButton bThoat = new JButton("Thoát");
		bThoat.setBounds(518, 205, 85, 38);
		bThoat.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		bThoat.setContentAreaFilled(false);
		getContentPane().add(bThoat);

		this.addWindowListener(new WindowAdapter() {

			public void windowOpened(WindowEvent ev) {
				try {

					Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
					String sql1 = "SELECT MALOAISACH FROM LOAISACH";
					ResultSet rs1 = statement.executeQuery(sql1);
					while (rs1.next()) {
						cbMaLoaiSach.addItem(rs1.getString("MALOAISACH"));

					}

				} catch (Exception e) {
					e.printStackTrace();
				}
				
				try {

					Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
					String sql2 = "SELECT MALINHVUC FROM LINHVUC";
					ResultSet rs2 = statement.executeQuery(sql2);
					
					while (rs2.next()) {
						cbMaLinhVuc.addItem(rs2.getString("MALINHVUC"));

					}

				} catch (Exception e) {
					e.printStackTrace();
				}

			}
		});
		
		tfTenTacGia.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent ev) {
				try {

					Statement statement = ketnoi.ConnectDB.getConnection().createStatement(ResultSet.TYPE_SCROLL_SENSITIVE,ResultSet.CONCUR_UPDATABLE);
					String sql = String.format("SELECT MATACGIA FROM TACGIA WHERE TENTACGIA = '%s'",tfTenTacGia.getText());
					ResultSet rs = statement.executeQuery(sql);
					while (rs.next()) {
						cbMaTacGia.addItem(rs.getString("MATACGIA"));
						rs.updateRow();
					}
					
					if(cbMaTacGia.getItemCount()== 0){
						NhapTacGia tg =  new NhapTacGia();
						tg.setTenTacGia(tfTenTacGia.getText());
						tg.setVisible(true);
					}
					
				} catch (Exception e) {
					e.printStackTrace();
				}
				
			}
		});
		
		cbMaLinhVuc.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent arg0) {
				tfMaLinhVuc.setText(cbMaLinhVuc.getSelectedItem().toString());
			}
		});
		
		cbMaLoaiSach.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				tfMaLoaiSach.setText(cbMaLoaiSach.getSelectedItem().toString());
			}
		});
		
		cbMaTacGia.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				tfMaTacGia.setText(String.valueOf(cbMaTacGia.getSelectedItem()));
			}
		});
		
		lbMaTacGia.addMouseListener(new MouseListener() {
			
			@Override
			public void mouseReleased(MouseEvent arg0) {
				
			}
			
			@Override
			public void mousePressed(MouseEvent arg0) {
				
				
			}
			
			@Override
			public void mouseExited(MouseEvent arg0) {
				lbMaTacGia.setForeground(Color.BLACK);
				
			}
			
			@Override
			public void mouseEntered(MouseEvent arg0) {
				lbMaTacGia.setForeground(Color.RED);
				lbMaTacGia.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
			}
			
			@Override
			public void mouseClicked(MouseEvent arg0) {
				XemTTTG tt = new XemTTTG();
				tt.setMaTacGia(tfMaTacGia.getText());
				tt.setVisible(true);		
			}
		});

		bThoat.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent arg0) {
				dispose();

			}
		});

		bReset.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				tfMaSach.setText("");
				tfTenSach.setText("");
				tfTenTacGia.setText("");
				tfLanTB.setText("");
				tfNamXB.setText("");
				tfGiaBia.setText("");
				tfNhaXB.setText("");
				tfMaLinhVuc.setText("");
				tfMaLoaiSach.setText("");
				tfMaTacGia.setEditable(false);
				cbMaTacGia.removeAllItems();
				tfMaTacGia.setText("");
				tfGiaNhap.setText("");
			}
		});

		tfMaSach.getDocument().addDocumentListener(new DocumentListener() {

			@Override
			public void removeUpdate(DocumentEvent e) {
				// TODO Auto-generated method stub

			}

			@Override
			public void insertUpdate(DocumentEvent e) {
				SwingUtilities.invokeLater(new Runnable() {
					public void run() {
						String masach = tfMaSach.getText();
						if (masach.length() == 13) {
							try {
								Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
								String sql = "SELECT MASACH FROM SACH";
								ResultSet rs = statement.executeQuery(sql);
								while (rs.next()) {
									if (masach.equals(rs.getString("MASACH"))) {
										JOptionPane.showMessageDialog(null,"Sách đã được khai báo", "Thông báo",JOptionPane.ERROR_MESSAGE);
										tfMaSach.setText("");
									}
								}

							} catch (Exception e) {
								e.printStackTrace();
							}
						}
						
						if(masach.length()>13){
							JOptionPane.showMessageDialog(null,"Mã sách không đúng quy định!","Lỗi",JOptionPane.ERROR_MESSAGE);
							tfMaSach.setText("");
						}

						
					}
				});

			}

			@Override
			public void changedUpdate(DocumentEvent e) {
				// TODO Auto-generated method stub

			}
		});

		bKhaiBao.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent event) {
				try {

					String masach = tfMaSach.getText();
					String tensach = tfTenSach.getText();
					String matacgia = tfMaTacGia.getText();
					String malinhvuc = tfMaLinhVuc.getText();
					String maloaisach = tfMaLoaiSach.getText();
					String lantb = tfLanTB.getText();
					String namxb = tfNamXB.getText();
					int gianhap = Integer.valueOf(tfGiaNhap.getText());
					int giabia = Integer.valueOf(tfGiaBia.getText());
					String NXB = tfNhaXB.getText();
					;

					if (tfLanTB.getText().equals("")) {
						lantb = "NULL";
					}

					if (tfNamXB.getText().equals("")) {
						namxb = "NULL";
					}

					if (tfNhaXB.getText().equals("")) {
						NXB = "NULL";
					}
				
				Statement statement =ketnoi.ConnectDB.getConnection().createStatement(); 
				String sql1 = String.format("INSERT INTO SACH VALUES ('%s','%s','%s','%s','%s','%d')",masach,tensach.toUpperCase(),matacgia,maloaisach,malinhvuc,gianhap); 
				String sql2 = String.format("INSERT INTO THONGTINXUATBAN VALUES ('%s','%s','%s','%s','%d')",masach,lantb,namxb,NXB.toUpperCase(),giabia);
				int n = statement.executeUpdate(sql1); 
				int m =statement.executeUpdate(sql2);
			    if(n == 1){ 
			    	JOptionPane.showMessageDialog(null,"Dữ liệu của sách đã được khai báo","Hoàn tất",JOptionPane.INFORMATION_MESSAGE); 
			     }
				else{ 
					JOptionPane.showMessageDialog(null,"Không khai báo dữ liệu sách được","Thông báo",JOptionPane.ERROR_MESSAGE); 
				 }
				if(m == 1){ 
					JOptionPane.showMessageDialog(null,"Thông tin xuất bản đã được đính kèm","Hoàn tất",JOptionPane.INFORMATION_MESSAGE); 
				}
					  
				else{ 
					JOptionPane.showMessageDialog(null,"Thông tin xuất bản không được đính kèm","Thông báo",JOptionPane.ERROR_MESSAGE); 
					}
					 
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}
	
	public static void main(String[] args) {
		new KhaiBaoSach().setVisible(true);
	}

    public void setSelected(boolean b) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
}

