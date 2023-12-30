package GUI.FrameControlKhuyenMai;

import java.awt.Cursor;
import java.awt.Toolkit;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.TitledBorder;
import javax.swing.JRadioButton;
import java.awt.Font;
import javax.swing.BorderFactory;
import javax.swing.DefaultListModel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.JList;
import javax.swing.JScrollPane;
import javax.swing.JButton;
import javax.swing.SwingUtilities;
import javax.swing.border.LineBorder;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;
import java.awt.Color;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.ResultSet;
import java.sql.Statement;
import javax.swing.ButtonGroup;


public class HuyChuongTrinhKM extends JFrame {
	private JTextField tfNXB;
	DefaultListModel modelList = new DefaultListModel();
	JList list = new JList(modelList);
	String inUse;
	private final ButtonGroup buttonGroup = new ButtonGroup();

	public HuyChuongTrinhKM() {
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setSize(284, 273);
		setResizable(false);
		setLocationRelativeTo(null);
		setIconImage(Toolkit.getDefaultToolkit().getImage(GUI.FrameControlCongcu.TimMaSach.class.getResource("/data/img/delete.png")));
		setTitle("Hủy chương trình KM");
		getContentPane().setLayout(null);
		
		JPanel panel = new JPanel();
		panel.setBorder(new TitledBorder(new LineBorder(new Color(192, 192, 192)), "Th\u00F4ng tin khuy\u1EBFn m\u00E3i", TitledBorder.LEADING, TitledBorder.TOP, null, null));
		panel.setBounds(10, 11, 257, 85);
		getContentPane().add(panel);
		panel.setLayout(null);
		
		JRadioButton rbLoaiSach = new JRadioButton("Loại sách");
		buttonGroup.add(rbLoaiSach);
		rbLoaiSach.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		rbLoaiSach.setBounds(3, 17, 86, 23);
		panel.add(rbLoaiSach);
		
		JRadioButton rbNXB = new JRadioButton("Nhà xuất bản");
		buttonGroup.add(rbNXB);
		rbNXB.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		rbNXB.setBounds(3, 52, 107, 23);
		panel.add(rbNXB);
		
		tfNXB = new JTextField();
		tfNXB.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		tfNXB.setBounds(111, 54, 138, 20);
		panel.add(tfNXB);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(10, 104, 193, 130);
		getContentPane().add(scrollPane);
		scrollPane.setViewportView(list);
		
		JButton bXoa = new JButton("Xóa");
		bXoa.setBounds(207, 104, 60, 130);
		bXoa.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		bXoa.setContentAreaFilled(false);
		getContentPane().add(bXoa);
		
       rbLoaiSach.addActionListener(new ActionListener() {
		
		@Override
		public void actionPerformed(ActionEvent ev) {
			tfNXB.setEditable(false);
			tfNXB.setText("");
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
				tfNXB.setEditable(true);
				tfNXB.setText("");
				modelList.removeAllElements();
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
       
       bXoa.addActionListener(new ActionListener() {
		
		@Override
		public void actionPerformed(ActionEvent ev) {
			if(inUse == "Loai sach"){
				try{
					String ls = String.valueOf(list.getSelectedValue());
					Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
					String sql = String.format("DELETE FROM SACHKHUYENMAI WHERE EXISTS (SELECT MASACH FROM SACH,LOAISACH WHERE SACH.MALOAISACH = LOAISACH.MALOAISACH AND SACH.MASACH = SACHKHUYENMAI.MASACH AND TENLOAISACH = '%s')",ls);
					int n = statement.executeUpdate(sql);
					
					if(n>=1){
						JOptionPane.showMessageDialog(null, "Hủy chương trình khuyến mãi thành công");
					}
					
				}catch (Exception e) {
					e.printStackTrace();
				}
			}
			
			else{
				try{
					String nxb = String.valueOf(list.getSelectedValue());
					Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
					String sql = String.format("DELETE FROM SACHKHUYENMAI WHERE EXISTS (SELECT SACH.MASACH FROM SACH,THONGTINXUATBAN WHERE SACH.MASACH = THONGTINXUATBAN.MASACH AND SACH.MASACH = SACHKHUYENMAI.MASACH AND NHAXUATBAN = '%s')",nxb);
					int n = statement.executeUpdate(sql);
					
					if(n>=1){
						JOptionPane.showMessageDialog(null, "Hủy chương trình khuyến mãi thành công");
					}
					
				}catch (Exception e) {
					e.printStackTrace();
				}
			}
			
		}
	});
	}
	
	public static void main(String[] args) {
		new HuyChuongTrinhKM().setVisible(true);
	}

    public void setSelected(boolean b) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
}
