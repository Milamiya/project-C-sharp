package GUI.Menu;

import GUI.FrameControlHeThong.DoiMatKhau;
import GUI.FrameControlHeThong.TaoTaiKhoan;
//import GUI.FrameControlHeThong.JIFInfo;
//import GUI.FrameControlHeThong.JIFSaoLuuData;
//import GUI.FrameControlHeThong.JIFXoaData;
import java.beans.PropertyVetoException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.ImageIcon;
import javax.swing.JDesktopPane;
import javax.swing.JOptionPane;

/**
 *
 * @author 10520_000
 */
public class JIFHeThong extends javax.swing.JInternalFrame {

    private JDesktopPane desktop;
    /**
     * Creates new form JIFDanhMuc
     */
    public JIFHeThong() throws PropertyVetoException {
        
        this.setFrameIcon(new ImageIcon("src/Image/login.png"));
       javax.swing.plaf.InternalFrameUI gui  = this.getUI();  
            ((javax.swing.plaf.basic.BasicInternalFrameUI)gui).setNorthPane(null);
        initComponents();
        
        
    }
   
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jScrollPane1 = new javax.swing.JScrollPane();
        jTree1 = new javax.swing.JTree();
        jPanelHeThong = new javax.swing.JPanel();
        jLabelTieuDe5 = new javax.swing.JLabel();
        jButtonTaoTaiKhoan = new javax.swing.JButton();
        jButtonDoiMatKhau = new javax.swing.JButton();

        jScrollPane1.setViewportView(jTree1);

        setClosable(true);
        setIconifiable(true);
        setMaximizable(true);
        setMaximumSize(new java.awt.Dimension(80, 80));
        addComponentListener(new java.awt.event.ComponentAdapter() {
            public void componentMoved(java.awt.event.ComponentEvent evt) {
                formComponentMoved(evt);
            }
        });

        jPanelHeThong.setBorder(javax.swing.BorderFactory.createEtchedBorder());

        jLabelTieuDe5.setBackground(new java.awt.Color(255, 153, 255));
        jLabelTieuDe5.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabelTieuDe5.setForeground(new java.awt.Color(255, 255, 255));
        jLabelTieuDe5.setText("Hệ thống");

        jButtonTaoTaiKhoan.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Image/quyen.png"))); // NOI18N
        jButtonTaoTaiKhoan.setText("Tạo tài khoản");
        jButtonTaoTaiKhoan.setHorizontalAlignment(javax.swing.SwingConstants.LEFT);
        jButtonTaoTaiKhoan.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonTaoTaiKhoanActionPerformed(evt);
            }
        });

        jButtonDoiMatKhau.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Image/key.png"))); // NOI18N
        jButtonDoiMatKhau.setText("Đổi mật khẩu");
        jButtonDoiMatKhau.setHorizontalAlignment(javax.swing.SwingConstants.LEFT);
        jButtonDoiMatKhau.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonDoiMatKhauActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanelHeThongLayout = new javax.swing.GroupLayout(jPanelHeThong);
        jPanelHeThong.setLayout(jPanelHeThongLayout);
        jPanelHeThongLayout.setHorizontalGroup(
            jPanelHeThongLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanelHeThongLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jPanelHeThongLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabelTieuDe5, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanelHeThongLayout.createSequentialGroup()
                        .addGroup(jPanelHeThongLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jButtonDoiMatKhau, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(jButtonTaoTaiKhoan, javax.swing.GroupLayout.DEFAULT_SIZE, 205, Short.MAX_VALUE))
                        .addContainerGap())))
        );
        jPanelHeThongLayout.setVerticalGroup(
            jPanelHeThongLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanelHeThongLayout.createSequentialGroup()
                .addComponent(jLabelTieuDe5, javax.swing.GroupLayout.PREFERRED_SIZE, 30, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jButtonTaoTaiKhoan)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jButtonDoiMatKhau)
                .addContainerGap(67, Short.MAX_VALUE))
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jPanelHeThong, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jPanelHeThong, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(124, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void formComponentMoved(java.awt.event.ComponentEvent evt) {//GEN-FIRST:event_formComponentMoved
        // TODO add your handling code here:
        // TODO add your handling code here:
        
    }//GEN-LAST:event_formComponentMoved

    private void jButtonTaoTaiKhoanActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonTaoTaiKhoanActionPerformed
        // TODO add your handling code here:
        if(desktop.getComponentCount() != 0)
            desktop.getComponent(0).setVisible(false);
        //desktop.removeAll();
        TaoTaiKhoan frame;
        try {
           frame = new TaoTaiKhoan();
            frame.setVisible(true);
           getDesktop().add(frame);
            frame.setSelected(true);
        } catch (Exception ex) {
           Logger.getLogger(JIFTainguyen.class.getName()).log(Level.SEVERE, null, ex);
       }
        
        
    }//GEN-LAST:event_jButtonTaoTaiKhoanActionPerformed

    private void jButtonDoiMatKhauActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonDoiMatKhauActionPerformed
        // TODO add your handling code here:
       if(desktop.getComponentCount() != 0)
           desktop.getComponent(0).setVisible(false);
      //desktop.removeAll();
       DoiMatKhau frame;
       try {
            frame = new DoiMatKhau();
           frame.setVisible(true);
           getDesktop().add(frame);
            frame.setSelected(true);
       } catch (Exception ex) {
            Logger.getLogger(JIFTainguyen.class.getName()).log(Level.SEVERE, null, ex);
        }
        
    }//GEN-LAST:event_jButtonDoiMatKhauActionPerformed

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButtonDoiMatKhau;
    private javax.swing.JButton jButtonTaoTaiKhoan;
    private javax.swing.JLabel jLabelTieuDe5;
    private javax.swing.JPanel jPanelHeThong;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTree jTree1;
    // End of variables declaration//GEN-END:variables

    /**
     * @return the desktop
     */
    public JDesktopPane getDesktop() {
        return desktop;
    }

    
    public void setDesktop(JDesktopPane desktop) {
        this.desktop = desktop;
    }
}
