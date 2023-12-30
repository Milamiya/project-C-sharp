
package GUI.Menu;

import GUI.FrameControlBaoCao.ThongKeDoanhThu;
import GUI.FrameControlBaoCao.ThongKeSach;
import java.beans.PropertyVetoException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.ImageIcon;
import javax.swing.JDesktopPane;

/**
 *
 * @author 10520_000
 */
public class JIFBaoCao extends javax.swing.JInternalFrame {

    private JDesktopPane desktop;
    /**
     * Creates new form JIFDanhMuc
     */
    public JIFBaoCao() throws PropertyVetoException {
        
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
        jPanelBaoCao = new javax.swing.JPanel();
        jLabelTieuDe4 = new javax.swing.JLabel();
        jButtonThongKeSach = new javax.swing.JButton();
        jButtonThongKeDoanhThu = new javax.swing.JButton();
        jInternalFrame1 = new javax.swing.JInternalFrame();
        jPanelBaoCao1 = new javax.swing.JPanel();
        jLabelTieuDe5 = new javax.swing.JLabel();
        

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

        jPanelBaoCao.setBorder(javax.swing.BorderFactory.createEtchedBorder());
        jPanelBaoCao.setPreferredSize(new java.awt.Dimension(238, 311));

        jLabelTieuDe4.setBackground(new java.awt.Color(255, 153, 255));
        jLabelTieuDe4.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabelTieuDe4.setForeground(new java.awt.Color(255, 255, 255));
        jLabelTieuDe4.setText("Báo cáo");

        jButtonThongKeSach.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Image/report.png"))); // NOI18N
        jButtonThongKeSach.setText("Thống kê sách");
        jButtonThongKeSach.setHorizontalAlignment(javax.swing.SwingConstants.LEFT);
        jButtonThongKeSach.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonThongKeSachActionPerformed(evt);
            }
        });

        jButtonThongKeDoanhThu.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Image/report1.png"))); // NOI18N
        jButtonThongKeDoanhThu.setText("Thống kê doanh thu");
        jButtonThongKeDoanhThu.setHorizontalAlignment(javax.swing.SwingConstants.LEFT);
        jButtonThongKeDoanhThu.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonThongKeDoanhThuActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanelBaoCaoLayout = new javax.swing.GroupLayout(jPanelBaoCao);
        jPanelBaoCao.setLayout(jPanelBaoCaoLayout);
        jPanelBaoCaoLayout.setHorizontalGroup(
            jPanelBaoCaoLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanelBaoCaoLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jPanelBaoCaoLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabelTieuDe4, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanelBaoCaoLayout.createSequentialGroup()
                        .addGroup(jPanelBaoCaoLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(jButtonThongKeDoanhThu, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(jButtonThongKeSach, javax.swing.GroupLayout.DEFAULT_SIZE, 223, Short.MAX_VALUE))
                        .addContainerGap())))
        );
        jPanelBaoCaoLayout.setVerticalGroup(
            jPanelBaoCaoLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanelBaoCaoLayout.createSequentialGroup()
                .addComponent(jLabelTieuDe4, javax.swing.GroupLayout.PREFERRED_SIZE, 30, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jButtonThongKeSach)
                .addGap(18, 18, 18)
                .addComponent(jButtonThongKeDoanhThu)
                .addContainerGap(74, Short.MAX_VALUE))
        );

        jInternalFrame1.setClosable(true);
        jInternalFrame1.setIconifiable(true);
        jInternalFrame1.setMaximizable(true);
        jInternalFrame1.setMaximumSize(new java.awt.Dimension(80, 80));
        jInternalFrame1.addComponentListener(new java.awt.event.ComponentAdapter() {
            public void componentMoved(java.awt.event.ComponentEvent evt) {
                jInternalFrame1formComponentMoved(evt);
            }
        });

        jPanelBaoCao1.setBorder(javax.swing.BorderFactory.createEtchedBorder());
        jPanelBaoCao1.setPreferredSize(new java.awt.Dimension(238, 311));

        jLabelTieuDe5.setBackground(new java.awt.Color(255, 153, 255));
        jLabelTieuDe5.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabelTieuDe5.setForeground(new java.awt.Color(255, 255, 255));
        jLabelTieuDe5.setText("Báo cáo");

        

        javax.swing.GroupLayout jPanelBaoCao1Layout = new javax.swing.GroupLayout(jPanelBaoCao1);
        jPanelBaoCao1.setLayout(jPanelBaoCao1Layout);
        jPanelBaoCao1Layout.setHorizontalGroup(
            jPanelBaoCao1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanelBaoCao1Layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jPanelBaoCao1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabelTieuDe5, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanelBaoCao1Layout.createSequentialGroup()
                        .addGroup(jPanelBaoCao1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            
                            )
                        .addContainerGap())))
        );
        jPanelBaoCao1Layout.setVerticalGroup(
            jPanelBaoCao1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanelBaoCao1Layout.createSequentialGroup()
                .addComponent(jLabelTieuDe5, javax.swing.GroupLayout.PREFERRED_SIZE, 30, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
               .addContainerGap(86, Short.MAX_VALUE))
        );

        javax.swing.GroupLayout jInternalFrame1Layout = new javax.swing.GroupLayout(jInternalFrame1.getContentPane());
        jInternalFrame1.getContentPane().setLayout(jInternalFrame1Layout);
        jInternalFrame1Layout.setHorizontalGroup(
            jInternalFrame1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 0, Short.MAX_VALUE)
            .addGroup(jInternalFrame1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(jInternalFrame1Layout.createSequentialGroup()
                    .addContainerGap()
                    .addComponent(jPanelBaoCao1, javax.swing.GroupLayout.DEFAULT_SIZE, 181, Short.MAX_VALUE)
                    .addContainerGap()))
        );
        jInternalFrame1Layout.setVerticalGroup(
            jInternalFrame1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 0, Short.MAX_VALUE)
            .addGroup(jInternalFrame1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(jInternalFrame1Layout.createSequentialGroup()
                    .addContainerGap()
                    .addComponent(jPanelBaoCao1, javax.swing.GroupLayout.PREFERRED_SIZE, 198, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addContainerGap(90, Short.MAX_VALUE)))
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 267, Short.MAX_VALUE)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(layout.createSequentialGroup()
                    .addContainerGap()
                    .addComponent(jPanelBaoCao, javax.swing.GroupLayout.DEFAULT_SIZE, 247, Short.MAX_VALUE)
                    .addContainerGap()))
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(layout.createSequentialGroup()
                    .addGap(0, 133, Short.MAX_VALUE)
                    .addComponent(jInternalFrame1, javax.swing.GroupLayout.PREFERRED_SIZE, 0, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addGap(0, 134, Short.MAX_VALUE)))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 327, Short.MAX_VALUE)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(layout.createSequentialGroup()
                    .addContainerGap()
                    .addComponent(jPanelBaoCao, javax.swing.GroupLayout.PREFERRED_SIZE, 198, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addContainerGap(118, Short.MAX_VALUE)))
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(layout.createSequentialGroup()
                    .addGap(0, 163, Short.MAX_VALUE)
                    .addComponent(jInternalFrame1, javax.swing.GroupLayout.PREFERRED_SIZE, 0, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addGap(0, 164, Short.MAX_VALUE)))
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

    private void jButtonThongKeSachActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonThongKeSachActionPerformed
        // TODO add your handling code here:
        if(desktop.getComponentCount() != 0)
            desktop.getComponent(0).setVisible(false);
      //  desktop.removeAll();
        ThongKeSach frame;
        try {
            frame = new ThongKeSach();
            frame.setVisible(true);
            getDesktop().add(frame);
            frame.setSelected(true);
        } catch (Exception e) {
            Logger.getLogger(JIFTainguyen.class.getName()).log(Level.SEVERE, null, e);
        }
    }//GEN-LAST:event_jButtonThongKeSachActionPerformed

    private void jButtonThongKeDoanhThuActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonThongKeDoanhThuActionPerformed
        // TODO add your handling code here:
        if(desktop.getComponentCount() != 0)
            desktop.getComponent(0).setVisible(false);
        desktop.removeAll();
        ThongKeDoanhThu frame;
        try {
            frame = new ThongKeDoanhThu();
            frame.setVisible(true);
            getDesktop().add(frame);
            frame.setSelected(true);
        } catch (Exception e) {
            Logger.getLogger(JIFTainguyen.class.getName()).log(Level.SEVERE, null, e);
        }
    }//GEN-LAST:event_jButtonThongKeDoanhThuActionPerformed

    private void jButtonThongKeSach1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonThongKeSach1ActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_jButtonThongKeSach1ActionPerformed

    private void jButtonThongKeDoanhThu1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonThongKeDoanhThu1ActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_jButtonThongKeDoanhThu1ActionPerformed

    private void jInternalFrame1formComponentMoved(java.awt.event.ComponentEvent evt) {//GEN-FIRST:event_jInternalFrame1formComponentMoved
        // TODO add your handling code here:
    }//GEN-LAST:event_jInternalFrame1formComponentMoved

    // Variables declaration - do not modify//GEN-BEGIN:variables
    
    private javax.swing.JButton jButtonThongKeDoanhThu;
    private javax.swing.JButton jButtonThongKeSach;
    private javax.swing.JInternalFrame jInternalFrame1;
    private javax.swing.JLabel jLabelTieuDe4;
    private javax.swing.JLabel jLabelTieuDe5;
    private javax.swing.JPanel jPanelBaoCao;
    private javax.swing.JPanel jPanelBaoCao1;
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
