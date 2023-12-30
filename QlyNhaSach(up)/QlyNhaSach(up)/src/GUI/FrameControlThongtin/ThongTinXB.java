package GUI.FrameControlThongtin;

//import .*;
import java.awt.Toolkit;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.Vector;
import javax.swing.JFrame;
import javax.swing.JTable;
import javax.swing.JScrollPane;
import javax.swing.table.DefaultTableModel;



public class ThongTinXB extends JFrame {
	private JTable table;

	public ThongTinXB() {
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setSize(842, 395);
		setResizable(false);
		setLocationRelativeTo(null);
		setIconImage(Toolkit.getDefaultToolkit().getImage(GUI.FrameControlCongcu.TimMaSach.class.getResource("/data/img/kb.png")));
		setTitle("Thông tin xuất bản");
		getContentPane().setLayout(null);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(10, 11, 816, 344);
		getContentPane().add(scrollPane);
		
		table = new JTable();
		scrollPane.setViewportView(table);
		
		LoadTable();
	}
	
	public void LoadTable(){
		try {

			Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
			String sql = "SELECT THONGTINXUATBAN.MASACH,TENSACH,LANTAIBAN,NAMXUATBAN,NHAXUATBAN,GIABIA FROM SACH,THONGTINXUATBAN WHERE SACH.MASACH = THONGTINXUATBAN.MASACH";
			ResultSet rs = statement.executeQuery(sql);
			Vector col = new Vector();
	        Vector data = new Vector();
	        col.add("Mã sách");
	        col.add("Tên sách");
	        col.add("Lần tái bản");
	        col.add("Năm xuất bản");
	        col.add("Nhà xuất bản");
	        col.add("Giá bìa");
	        

			while (rs.next()) {
				Vector row = new Vector();
                for (int i = 1; i <= 6; i++) {
                    row.add(rs.getString(i));
                }
                data.add(row);
			}
			table.setModel(new DefaultTableModel(data, col));
			table.getColumnModel().getColumn(0).setPreferredWidth(24);
			table.getColumnModel().getColumn(1).setPreferredWidth(200);
			table.getColumnModel().getColumn(2).setPreferredWidth(7);
			table.getColumnModel().getColumn(3).setPreferredWidth(15);
			table.getColumnModel().getColumn(4).setPreferredWidth(100);
			table.getColumnModel().getColumn(5).setPreferredWidth(10);

		} catch (Exception e) {
			e.printStackTrace();
		}
	}
	
	public static void main(String[] args) {
		new ThongTinXB().setVisible(true);
	}

    public void setSelected(boolean b) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

}
