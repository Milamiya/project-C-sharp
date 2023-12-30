package GUI.FrameControlKhuyenMai;

import java.awt.Color;
import java.awt.Cursor;
import java.awt.EventQueue;
import java.awt.Toolkit;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.TitledBorder;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;
import javax.swing.JRadioButton;
import java.awt.Font;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.ResultSet;
import javax.swing.BorderFactory;
import javax.swing.DefaultListModel;
import javax.swing.JOptionPane;
import javax.swing.SwingUtilities;
import javax.swing.UIManager;
import javax.swing.JTextField;
import javax.swing.JList;
import javax.swing.JScrollPane;
import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.ButtonGroup;
import java.sql.Statement;


public class LapChuongTrinhKhuyenMai extends JFrame {
	private JTextField tfLoaiSach;
	private JTextField tfNXB;
	private JTextField tfMucGiamGia;
	private final ButtonGroup buttonGroup = new ButtonGroup();
	DefaultListModel modelList = new DefaultListModel();
	JList list = new JList(modelList);
	String inUse;
	String ms[];
	String mas[];


	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					LapChuongTrinhKhuyenMai frame = new LapChuongTrinhKhuyenMai();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public LapChuongTrinhKhuyenMai() {
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setSize(483, 250);
		setResizable(false);
		setIconImage(Toolkit.getDefaultToolkit().getImage(GUI.FrameControlCongcu.TimMaSach.class.getResource("/data/img/sale.png")));
		setTitle("Lập chương trình khuyến mãi");
		setLocationRelativeTo(null);
		getContentPane().setLayout(null);
		
		JPanel panel = new JPanel();
		panel.setBorder(new TitledBorder(UIManager.getBorder("TitledBorder.border"), "Th\u00F4ng tin khuy\u1EBFn m\u00E3i", TitledBorder.LEADING, TitledBorder.TOP, null, null));
		panel.setBounds(10, 11, 272, 125);
		getContentPane().add(panel);
		panel.setLayout(null);
		
		JRadioButton rbMaLoaiSach = new JRadioButton("Loại sách");
		buttonGroup.add(rbMaLoaiSach);
		rbMaLoaiSach.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		rbMaLoaiSach.setBounds(3, 21, 86, 23);
		panel.add(rbMaLoaiSach);
		
		JRadioButton rbNXB = new JRadioButton("Nhà xuất bản");
		buttonGroup.add(rbNXB);
		rbNXB.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		rbNXB.setBounds(3, 55, 107, 23);
		panel.add(rbNXB);
		
		tfLoaiSach = new JTextField();
		tfLoaiSach.setEditable(false);
		tfLoaiSach.setBounds(112, 23, 150, 20);
		panel.add(tfLoaiSach);
		tfLoaiSach.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		
		tfNXB = new JTextField();
		tfNXB.setEditable(false);
		tfNXB.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		tfNXB.setBounds(112, 57, 149, 20);
		panel.add(tfNXB);
		
		JLabel lbMucGiamGia = new JLabel("Mức giảm giá");
		lbMucGiamGia.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbMucGiamGia.setBounds(13, 90, 86, 21);
		panel.add(lbMucGiamGia);
		
		tfMucGiamGia = new JTextField();
		tfMucGiamGia.setEditable(false);
		tfMucGiamGia.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		tfMucGiamGia.setBounds(112, 91, 68, 20);
		panel.add(tfMucGiamGia);
		
		JLabel lblNewLabel = new JLabel("%");
		lblNewLabel.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lblNewLabel.setBounds(190, 94, 46, 14);
		panel.add(lblNewLabel);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(292, 18, 173, 155);
		getContentPane().add(scrollPane);
		scrollPane.setViewportView(list);
		
		JButton bChon = new JButton("Chọn");
		bChon.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		bChon.setBounds(292, 176, 173, 33);
		bChon.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		bChon.setContentAreaFilled(false);
		getContentPane().add(bChon);
		
		JButton bOK = new JButton("OK");
		bOK.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		bOK.setBounds(10, 140, 272, 33);
		bOK.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		bOK.setContentAreaFilled(false);
		getContentPane().add(bOK);
		
		JButton bReset = new JButton("Reset");
		bReset.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		bReset.setBounds(10, 176, 272, 33);
		bReset.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		bReset.setContentAreaFilled(false);
		getContentPane().add(bReset);
		
		rbMaLoaiSach.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent arg0) {
				tfLoaiSach.requestFocus();
				tfLoaiSach.setEditable(true);
				tfNXB.setEditable(false);
				tfMucGiamGia.setEditable(true);
				tfLoaiSach.setText("");
				tfNXB.setText("");
				tfMucGiamGia.setText("");
				modelList.removeAllElements();
				
				inUse = "Loai sach";
				try {

					Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
					String sql = "SELECT TENLOAISACH FROM LOAISACH";
					ResultSet rs = statement.executeQuery(sql);

					while (rs.next()) {
						modelList.addElement(rs.getString("TENLOAISACH"));
					}

				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
		
		rbNXB.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent arg0) {
				tfNXB.requestFocus();
				tfLoaiSach.setEditable(false);
				tfNXB.setEditable(true);
				tfMucGiamGia.setEditable(true);
				tfLoaiSach.setText("");
				tfNXB.setText("");
				tfMucGiamGia.setText("");
				modelList.removeAllElements();
			}
		});
		
		bChon.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				if(inUse.equals("Loai sach")){
					tfLoaiSach.setText(String.valueOf(list.getSelectedValue()));
					modelList.removeAllElements();
					tfMucGiamGia.requestFocus();
				}
				
				if(inUse.equals("NXB")){
					tfNXB.setText(String.valueOf(list.getSelectedValue()));
					modelList.removeAllElements();
					tfMucGiamGia.requestFocus();
				}
			}
		});
		
		bReset.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				
				tfLoaiSach.setEditable(false);
				tfNXB.setEditable(false);
				tfMucGiamGia.setEditable(false);
				tfLoaiSach.setText("");
				tfNXB.setText("");
				tfMucGiamGia.setText("");
				modelList.removeAllElements();
				buttonGroup.clearSelection();
			}
		});
		
		tfNXB.getDocument().addDocumentListener(new DocumentListener() {
			
			@Override
			public void removeUpdate(DocumentEvent arg0) {
				// TODO Auto-generated method stub
				
			}
			
			@Override
			public void insertUpdate(DocumentEvent arg0) {
				
				SwingUtilities.invokeLater(new Runnable()
				{
				    public void run()
				    {
				    	inUse = "NXB";
						try {

							Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
							String sql = "SELECT DISTINCT NHAXUATBAN FROM THONGTINXUATBAN WHERE NHAXUATBAN LIKE '"+ tfNXB.getText() + "%'";
							ResultSet rs = statement.executeQuery(sql);
							modelList.removeAllElements();

							while (rs.next()) {
								modelList.addElement(rs.getString("NHAXUATBAN"));
							}
							
							if(modelList.isEmpty()){
								JOptionPane.showMessageDialog(null,"Không tồn tại", "Thông báo", JOptionPane.ERROR_MESSAGE);
								tfNXB.setText("");
							}

						} catch (Exception e) {
							e.printStackTrace();
						}
				    	
				    }
				});		
				
				
				
			}
			
			@Override
			public void changedUpdate(DocumentEvent arg0) {
				// TODO Auto-generated method stub
				
			}
		});
		
		bOK.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent arg0) {
				
				if(inUse == "Loai sach"){
					
					try {
						int j = 0;
						int k=0;
						int m=0;
                        String loaisach =  tfLoaiSach.getText();
                        String masach = null;
                       
                        int mucgiamgia = Integer.valueOf(tfMucGiamGia.getText());
						Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
						String sql = String.format("SELECT MASACH FROM SACH,LOAISACH WHERE SACH.MALOAISACH = LOAISACH.MALOAISACH AND TENLOAISACH = '%s'",loaisach);
						ResultSet rs = statement.executeQuery(sql);
						
						while(rs.next()){
							j++;
						}
						
						rs.close();
						
                        ms = new String[j];
                        mas = new String[j];
                        
                        String sql1 = String.format("SELECT MASACH FROM SACH,LOAISACH WHERE SACH.MALOAISACH = LOAISACH.MALOAISACH AND TENLOAISACH = '%s'",loaisach);
						ResultSet rs1 = statement.executeQuery(sql1);
						
						while(rs1.next()){
							masach = rs1.getString("MASACH");
							ms[k] = masach;
							k++;
						}
						
						String sql2 = String.format("SELECT MASACH FROM SACHKHUYENMAI");
						ResultSet rs2 = statement.executeQuery(sql2);
						int c = j;
						
						while(rs2.next()){
							
							for(int i=0; i<j ; i++){
								
								if(ms[i].equals(rs2.getString("MASACH"))){
									c --;
									if(JOptionPane.showConfirmDialog(null, "Mã sách"+ rs2.getString("MASACH")+"đã được khuyến mãi!Bạn có muốn chỉnh sửa lại mức giảm giá ko?","Lựa chọn",JOptionPane.YES_NO_OPTION)==JOptionPane.YES_OPTION){
										ChinhSuaKM km = new ChinhSuaKM();
										km.setMaSach(ms[i]);
										km.setVisible(true);
										
									}
								}
								else{
									mas[++m]=ms[i];
								}
							}	
						}
						
						
						if(c!=j){
							for(int i=1; i<c; i++){
								String sql3 = String.format("INSERT INTO SACHKHUYENMAI VALUES ('%s','%d')",mas[i],mucgiamgia);
								int n = statement.executeUpdate(sql3);				
							}
						}
						else{
							int n = 0;
							for(int i=0; i<j; i++){
								String sql3 = String.format("INSERT INTO SACHKHUYENMAI VALUES ('%s','%d')",ms[i],mucgiamgia);
								n = statement.executeUpdate(sql3);				
							}
							
							if(n>=1){
								JOptionPane.showMessageDialog(null, "Thành công");
							}
						}

					} catch (Exception e) {
						e.printStackTrace();
					}
				}
				
				if(inUse == "NXB"){
					try {
						
						int j=0;
						int k=0;
						int m=0;
                        String nxb =  tfNXB.getText();
                        String masach = null;
						Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
						String sql = String.format("SELECT MASACH FROM THONGTINXUATBAN WHERE NHAXUATBAN = '%s'",nxb);
						ResultSet rs = statement.executeQuery(sql);
						
						while(rs.next()){
							j++;
						}
						
                       rs.close();
						
                        ms = new String[j];
                        mas = new String[j];
                        
                        String sql1 = String.format("SELECT MASACH FROM THONGTINXUATBAN WHERE NHAXUATBAN = '%s'",nxb);
						ResultSet rs1 = statement.executeQuery(sql1);
                        
						while(rs1.next()){
							masach = rs1.getString("MASACH");
							ms[k] = masach;
							k++;
						}
						
						int mucgiamgia = Integer.valueOf(tfMucGiamGia.getText());
						
						String sql2 = String.format("SELECT MASACH FROM SACHKHUYENMAI");
						ResultSet rs2 = statement.executeQuery(sql2);
						
						
						int c = j;
						
                       while(rs2.next()){
							
							for(int i=0; i<j ; i++){
								
								if(ms[i].equals(rs2.getString("MASACH"))){
									c --;
									if(JOptionPane.showConfirmDialog(null, "Mã sách"+ rs2.getString("MASACH")+"đã được khuyến mãi!Bạn có muốn chỉnh sửa lại mức giảm giá ko?","Lựa chọn",JOptionPane.YES_NO_OPTION)==JOptionPane.YES_OPTION){
										ChinhSuaKM km = new ChinhSuaKM();
										km.setMaSach(ms[i]);
										km.setVisible(true);
										
									}
								}
								else{
									mas[++m]=ms[i];
								}
							}	
						}
					  
                       if(c!=j){
                    	   for(int i=1; i<=c; i++){
       						String sql3 = String.format("INSERT INTO SACHKHUYENMAI VALUES ('%s','%d')",mas[i],mucgiamgia);
       							int n = statement.executeUpdate(sql3);
       						}
						}
						else{
							int n = 0;
							
						    for(int i=0; i<=c; i++){
									String sql3 = String.format("INSERT INTO SACHKHUYENMAI VALUES ('%s','%d')",mas[i],mucgiamgia);
										 n = statement.executeUpdate(sql3);
									}
							if(n>=1){
								JOptionPane.showMessageDialog(null, "Thành công");
							}
						}
						
					 
					} catch (Exception e) {
						e.printStackTrace();
					}
				}
			}
		});
		
	}

    public void setSelected(boolean b) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
}

