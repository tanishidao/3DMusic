using UnityEngine;

/// <summary>
/// �X�N���[���V���b�g���L���v�`������T���v��
/// </summary>
/// 
public class ScreenShotCapturer : MonoBehaviour
{
    private void Update()
    {
        // �X�y�[�X�L�[�������ꂽ��
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // �X�N���[���V���b�g��ۑ�
            CaptureScreenShot("ScreenShot.png");
        }
    }

    // ��ʑS�̂̃X�N���[���V���b�g��ۑ�����
    private void CaptureScreenShot(string filePath)
    {
        ScreenCapture.CaptureScreenshot(filePath);
    }
}