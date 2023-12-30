
package GUI.Menu;

import GUI.FrameControlCongcu.KiemTraSoLuong;
import GUI.FrameControlCongcu.TimKiemSach;
import GUI.FrameControlCongcu.TimMaSach;
import java.beans.PropertyVetoException;
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.ImageIcon;
import javax.swing.JDesktopPane;

/**
 *
 * @author 10520_000
 */
public class JIFCongcu1 extends javax.swing.JInternalFrame {

    private JDesktopPane desktop;
    /**
     * Creates new form JIFDanhMuc
     */
    public JIFCongcu1() throws PropertyVetoException {
        
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
        jPanelKhoHang = new javax.swing.JPanel();
        jLabelTieuDe1 = new javax.swing.JLabel();
        jButtonTimMaSach = new javax.swing.JButton();
        jButtonTimKiemSach = new javax.swing.JButton();
        jButtonKiemTraSoLuong = new javax.swing.JButton();

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

        jPanelKhoHang.setBorder(javax.swing.BorderFactory.createEtchedBorder());
        jPanelKhoHang.setPreferredSize(new java.awt.Dimension(238, 127));

        jLabelTieuDe1.setBackground(new java.awt.Color(255, 153, 255));
        jLabelTieuDe1.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabelTieuDe1.setForeground(new java.awt.Color(255, 255, 255));
        jLabelTieuDe1.setText("Công cụ");

        jButtonTimMaSach.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Image/add.png"))); // NOI18N
        jButtonTimMaSach.setText("Tìm mã sách");
        jButtonTimMaSach.setHorizontalAlignment(javax.swing.SwingConstants.LEFT);
        jButtonTimMaSach.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonTimMaSachActionPerformed(evt);
            }
        });

        jButtonTimKiemSach.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Image/list.png"))); // NOI18N
        jButtonTimKiemSach.setText("Tìm kiếm sách");
        jButtonTimKiemSach.setHorizontalAlignment(javax.swing.SwingConstants.LEFT);
        jButtonTimKiemSach.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonTimKiemSachActionPerformed(evt);
            }
        });

        jButtonKiemTraSoLuong.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Image/report.png"))); // NOI18N
        jButtonKiemTraSoLuong.setText("Kiểm tra số lượng sách");
        jButtonKiemTraSoLuong.setHorizontalAlignment(javax.swing.SwingConstants.LEFT);
        jButtonKiemTraSoLuong.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonKiemTraSoLuongActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanelKhoHangLayout = new javax.swing.GroupLayout(jPanelKhoHang);
        jPanelKhoHang.setLayout(jPanelKhoHangLayout);
        jPanelKhoHangLayout.setHorizontalGroup(
            jPanelKhoHangLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanelKhoHangLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jPanelKhoHangLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jButtonKiemTraSoLuong, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(jButtonTimKiemSach, javax.swing.GroupLayout.DEFAULT_SIZE, 217, Short.MAX_VALUE)
                    .addComponent(jButtonTimMaSach, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addGroup(jPanelKhoHangLayout.createSequentialGroup()
                        .addGap(58, 58, 58)
                        .addComponent(jLabelTieuDe1, javax.swing.GroupLayout.PREFERRED_SIZE, 91, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(0, 0, Short.MAX_VALUE)))
                .addContainerGap())
        );
        jPanelKhoHangLayout.setVerticalGroup(
            jPanelKhoHangLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanelKhoHangLayout.createSequentialGroup()
                .addComponent(jLabelTieuDe1, javax.swing.GroupLayout.PREFERRED_SIZE, 30, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jButtonTimMaSach)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jButtonTimKiemSach)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jButtonKiemTraSoLuong)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 261, Short.MAX_VALUE)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(layout.createSequentialGroup()
                    .addContainerGap()
                    .addComponent(jPanelKhoHang, javax.swing.GroupLayout.DEFAULT_SIZE, 241, Short.MAX_VALUE)
                    .addContainerGap()))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 294, Short.MAX_VALUE)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(layout.createSequentialGroup()
                    .addContainerGap()
                    .addComponent(jPanelKhoHang, javax.swing.GroupLayout.PREFERRED_SIZE, 153, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addContainerGap(130, Short.MAX_VALUE)))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void formComponentMoved(java.awt.event.ComponentEvent evt) {//GEN-FIRST:event_formComponentMoved
        // TODO add your handling code here:
        // TODO add your handling code here:
        if(this.getLocation().y < 0){
            this.setLocation(this.getLocation().x, 0);
        }
        
        if(this.getLocation().x < 0){
            this.setLocation(0, this.getLocation().y);
        }
        
    }//GEN-LAST:event_formComponentMoved

    private void jButtonTimKiemSachActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonTimKiemSachActionPerformed
        // TODO add your handling code here:
        if(desktop.getComponentCount() != 0)
            desktop.getComponent(0).setVisible(false);
       // desktop.removeAll();
    
        TimKiemSach frame;
        try {
            frame = new TimKiemSach();
            frame.setVisible(true);
            getDesktop().add(frame);
            frame.setSelected(true);
        } catch (Exception ex) {
            Logger.getLogger(JIFTainguyen.class.getName()).log(Level.SEVERE, null, ex);
        }
    }//GEN-LAST:event_jButtonTimKiemSachActionPerformed

    private void jButtonKiemTraSoLuongActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonKiemTraSoLuongActionPerformed
        // TODO add your handling code here:
        if(desktop.getComponentCount() != 0)
            desktop.getComponent(0).setVisible(false);
      //  desktop.removeAll();
    
        KiemTraSoLuong frame;
        try {
            frame = new KiemTraSoLuong();
            frame.setVisible(true);
            getDesktop().add(frame);
            frame.setSelected(true);
        } catch (Exception ex) {
            Logger.getLogger(JIFTainguyen.class.getName()).log(Level.SEVERE, null, ex);
        }
    }//GEN-LAST:event_jButtonKiemTraSoLuongActionPerformed

    private void jButtonTimMaSachActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonTimMaSachActionPerformed
        try {
            // TODO add your handling code here:
            new TimMaSach().setVisible(true);
        } catch (Exception ex) {
            Logger.getLogger(JIFCongcu1.class.getName()).log(Level.SEVERE, null, ex);
        }
       
    }//GEN-LAST:event_jButtonTimMaSachActionPerformed

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButtonKiemTraSoLuong;
    private javax.swing.JButton jButtonTimKiemSach;
    private javax.swing.JButton jButtonTimMaSach;
    private javax.swing.JLabel jLabelTieuDe1;
    private javax.swing.JPanel jPanelKhoHang;
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
